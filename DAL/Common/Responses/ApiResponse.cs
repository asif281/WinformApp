using System.Net;

namespace BAL.Common.Responses
{

    public class ApiResponse : ApiResponse<object>
    {
    }

    public class ApiResponse<T> where T : class
    {
        public T Body { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public WebApiErrorResponse Error { get; set; }
    }

    public class WebApiErrorResponse
    {
        public bool IsClientError { get; set; }
        public bool IsServerError { get; set; }
        public string ErrorBody { get; set; }
    }
}
