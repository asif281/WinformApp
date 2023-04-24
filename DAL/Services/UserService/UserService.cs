using BAL.Common;
using BAL.Common.Constants;
using BAL.Common.Responses;
using BAL.Services.HttpService;
using System.Net;

namespace BAL.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IEasyHttpClient _easyHttpClient;
        public UserService(IEasyHttpClient easyHttpClient)
        {
            _easyHttpClient = easyHttpClient;
        }

        public async Task<ApiResponse<MyResponse>> UserLogin(string url,  string username, string password, string deviceName)
        {
            try
            {
                Dictionary<string, string> headers = new Dictionary<string, string>();

                LoginInfo login = new LoginInfo(username, password, deviceName);

                headers.Add("User-Agent", "B-WHERE v2.00");

                var response = await _easyHttpClient.Post<MyResponse>(url, login, null, headers);

                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ApiResponse<ProfileResponse>> GetUser(string url, string apiKey)
        {
            try
            {

                Dictionary<string, string> headers = new Dictionary<string, string>();

                headers.Add("Accept", "application/json");
                headers.Add("User-Agent", "B-WHERE v2.00");
                headers.Add("Authorization", "Bearer " + apiKey);

                Action<HttpWebRequest> requestFilter = (HttpWebRequest req) => {
                    foreach (var header in headers)
                    {
                        req.Headers[header.Key] = header.Value;
                    }
                };

                var response = await _easyHttpClient.Get<ProfileResponse>(url, requestFilter, null);

                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ApiResponse<ResultsData>> GetCustomerData(string url, string apiKey)
        {
            try
            {

                Dictionary<string, string> headers = new Dictionary<string, string>();

                headers.Add("Accept", "application/json");
                headers.Add("User-Agent", "B-WHERE v2.00");
                headers.Add("Authorization", "Bearer " + apiKey);

                Action<HttpWebRequest> requestFilter = (HttpWebRequest req) => {
                    foreach (var header in headers)
                    {
                        req.Headers[header.Key] = header.Value;
                    }
                };

                var response = await _easyHttpClient.Get<ResultsData>(ApiUrls.GetCustomerData, requestFilter, null);

                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
