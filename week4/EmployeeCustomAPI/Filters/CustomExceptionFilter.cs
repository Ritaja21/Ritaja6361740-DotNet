using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeCustomAPI.Filters;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        var message = $"[{DateTime.Now}] EXCEPTION: {exception.Message}{Environment.NewLine}";
        File.AppendAllText("log.txt", message);

        context.Result = new ObjectResult("An internal error occurred. Check logs.")
        {
            StatusCode = 500
        };
    }
}
