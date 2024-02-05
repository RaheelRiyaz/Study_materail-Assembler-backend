using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.Shared
{
    public class ApiResponse <T>
    {
        public bool IsSuccess { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; } = null!;
        public T? Result { get; set; }

        public static ApiResponse<T> SuccessResponse(T result, string message = "Success", HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new ApiResponse<T> { IsSuccess = true, Message = message, Result = result, StatusCode = statusCode };
        }



        public static ApiResponse<T> ErrorResponse(string message = "Error", HttpStatusCode statusCode = HttpStatusCode.InternalServerError, T? result = default)
        {
            return new ApiResponse<T> { Message = message, Result = result, StatusCode = statusCode };
        }
    }
}
