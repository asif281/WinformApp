using BAL.Common.Constants;

namespace BAL.Common.Responses
{
    public class WebApiResponse
    {
        public bool Success { get; set; }
        public string? Message { get; set; }

        public UserErrorCode? UserErrorCode { get; set; }
        public static WebApiResponse CreateSuccess(string message = null)
            => new WebApiResponse { Success = true, Message = message };

        public static WebApiResponse CreateFail(string message = null)
            => new WebApiResponse { Success = false, Message = message };

        public static WebApiResponse<T> CreateSuccess<T>(T data)
            => new WebApiResponse<T> { Success = true, Data = data };

        public static WebApiResponse<T> Create<T>(bool success, T data)
            => new WebApiResponse<T> { Success = success, Data = data };
    }

    public class WebApiResponse<T> : WebApiResponse
    {
        public T Data { get; set; }
    }
}
