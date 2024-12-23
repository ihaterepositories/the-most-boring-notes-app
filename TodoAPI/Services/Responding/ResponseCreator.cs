using TodoAPI.Services.Responding.Models;

namespace TodoAPI.Services.Responding;

public class ResponseCreator
{
    public ServiceResponse<T> CreateError<T>(string message)
    {
        return new ServiceResponse<T>
        {
            IsSuccess = false,
            Message = message
        };
    }
    
    public ServiceResponse<T> CreateOk<T>(T data, string message = "success")
    {
        return new ServiceResponse<T>
        {
            IsSuccess = true,
            Data = data,
            Message = message
        };
    }
}