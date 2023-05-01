using BAL.Common;
using BAL.Common.Responses;
using System.Net;

namespace BAL.Services.UserService
{
    public interface IUserService
    {
        Task<ApiResponse<MyResponse>> UserLogin(string url, string username, string password, string deviceName);
        Task<ApiResponse<ProfileResponse>> GetUser(string url, string apiKey);
        Task<ApiResponse<ResultsData>> GetCustomerData(string url, string apiKey);
        Task<ApiResponse<object>> SetUserAway(string url, string apiKey, UserAwayInfo userAwayInfo);
    }
}
