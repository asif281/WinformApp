using BAL.Common.Responses;
using Newtonsoft.Json.Linq;
using ServiceStack;
using System.Globalization;
using System.Net;

namespace BAL.Services.HttpService
{

    public class EasyHttpClient : IEasyHttpClient
    {
        #region Public Methods

        /// <summary>
        /// Send GET request
        /// </summary>
        public Task<ApiResponse<TModel>> Get<TModel>(string url, Action<HttpWebRequest> requestFilter = null, string token = null) where TModel : class
        {
            try
            {
                if (url == null) throw new ArgumentNullException(nameof(url));

                return MakeRequest<TModel>(onResponse => url.GetJsonFromUrlAsync(requestFilter, onResponse));

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Send POST request
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<ApiResponse<TModel>> Post<TModel>(string url, object data, string token = null, Dictionary<string, string> headers = null, RequestContentType contentType = RequestContentType.Json) where TModel : class
        {
            try
            {
                if (url == null) throw new ArgumentNullException(nameof(url));
                if (contentType == RequestContentType.FormUrlEncoded)
                {

                    var form = await SerializeToUrlForm(data);

                    return await MakeRequest<TModel>(onResponse => url.PostToUrlAsync(form, "application/json", (webReq) =>
                    {
                        ;
                        if (headers != null)
                        {
                            foreach (var item in headers)
                            {
                                webReq.Headers[item.Key] = item.Value;
                            }
                        }
                    }, onResponse));
                }
                return await MakeRequest<TModel>(onResponse => url.PostJsonToUrlAsync(data, (webReq) =>
                {
                    if (headers != null)
                    {
                        foreach (var item in headers)
                        {
                            webReq.Headers[item.Key] = item.Value;
                        }
                    }
                }, onResponse));
            }
            catch (Exception)
            {

                throw;
            }           
        }

        #endregion


        #region Private Methods
        private static string SerializePostValue(object value)
        {
            try
            {
                if (value == null)
                    return null;

                var stringValue = value as string;

                if (stringValue == null && value != null)
                {
                    stringValue = value is IFormattable formattable
                        ? formattable.ToString(null, CultureInfo.InvariantCulture)
                        : value.ToString();
                }

                return stringValue;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Task<string> SerializeToUrlForm(object data)
        {
            try
            {
                var requestParameters = new List<KeyValuePair<string, string>>();
                var requestType = data.GetType();
                var properties = requestType.GetProperties();

                foreach (var property in properties)
                {
                    var name = property.Name;
                    var value = property.GetValue(data);

                    requestParameters.Add(
                        new KeyValuePair<string, string>(name, SerializePostValue(value)));
                }

                var requestContent = new FormUrlEncodedContent(requestParameters);

                return requestContent.ReadAsStringAsync();
            }
            catch (Exception)
            {

                throw;
            }            
        }

        private async Task<ApiResponse<TModel>> MakeRequest<TModel>(Func<Action<HttpWebResponse>, Task<string>> func) where TModel : class
        {
            try
            {
                var response = await MakeRequest(func);

                if (response.Body != null)
                {
                    var responseData = (JToken)response.Body;

                    return new ApiResponse<TModel>
                    {
                        StatusCode = response.StatusCode,
                        Body = responseData.ToObject<TModel>(),
                        Error = response.Error
                    };
                }

                return new ApiResponse<TModel>
                {
                    StatusCode = response.StatusCode,
                    Body = null,
                    Error = response.Error
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<ApiResponse> MakeRequest(Func<Action<HttpWebResponse>, Task<string>> func)
        {
            var statusCode = default(HttpStatusCode);
            string jsonResponse;

            try
            {
                jsonResponse = await func(response =>
                {
                    statusCode = response.StatusCode;
                });
            }
            catch (AggregateException ex)
            {
                var inner = ex.Flatten().InnerException;
                if (inner is WebException wex)
                {
                    var error = HandleWebException(wex);

                    return new ApiResponse
                    {
                        Body = null,
                        StatusCode = wex.GetStatus() ?? statusCode,
                        Error = error
                    };
                }


                throw;
            }
            catch (Exception ex)
            {

                throw;
            }

            JToken body = null;
            if (!string.IsNullOrEmpty(jsonResponse))
            {
                try
                {
                    body = JToken.Parse(jsonResponse);
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            var apiResponse = new ApiResponse
            {
                Body = body,
                StatusCode = statusCode
            };

            return apiResponse;
        }

        private WebApiErrorResponse HandleWebException(Exception ex)
        {
            // handle codes and exceptions from the server
            var knownError = ex.IsBadRequest()
                             || ex.IsNotFound()
                             || ex.IsUnauthorized()
                             || ex.IsForbidden()
                             || ex.IsInternalServerError();

            var isAnyClientError = ex.IsAny400();
            var isAnyServerError = ex.IsAny500();
            var errorBody = ex.GetResponseBody();

            var errorResponse = new WebApiErrorResponse
            {
                IsClientError = isAnyClientError,
                IsServerError = isAnyServerError,
                ErrorBody = errorBody
            };

            return errorResponse;
        }
        #endregion

    }

    public enum RequestContentType
    {
        FormUrlEncoded,
        Json
    }

    public static class EasyHttpClientExtentions
    {
        public static bool IsOk(this HttpStatusCode statusCode) =>
            (int)statusCode >= 200 && (int)statusCode < 300;

        public static bool IsOk(this ApiResponse response) => response.StatusCode.IsOk();

        public static bool IsOk<T>(this ApiResponse<T> response) where T : class => response.StatusCode.IsOk();
    }

}