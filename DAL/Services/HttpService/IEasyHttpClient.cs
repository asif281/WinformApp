using BAL.Common.Responses;
using System.Net;

namespace BAL.Services.HttpService
{
    public interface IEasyHttpClient
    {
        Task<ApiResponse<TModel>> Get<TModel>(string url, Action<HttpWebRequest> requestFilter = null, string token = null) where TModel : class;
        Task<ApiResponse<TModel>> Post<TModel>(string url, object data, string token = null, Dictionary<string, string> headers = null, RequestContentType contentType = RequestContentType.Json) where TModel : class;
    }
}
