using desenroleApi.Domain.Dtos;
using desenroleApi.Domain.Exceptions;
using System.Text.Json;

namespace desenroleApi.Middlewares;

public class RestfulMiddleware(RequestDelegate next, ILogger<RestfulMiddleware> logger)
{
    private readonly RequestDelegate _next = next;
    private readonly ILogger<RestfulMiddleware> _logger = logger;

    public async Task Invoke(HttpContext context)
    {
        var error = new ErrorDto();
        var statusCode = 0;
        
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.ToString());

            using (var reader = new StreamReader(context.Request.Body))
            {
                await reader.ReadToEndAsync();
            }

            if (ex is BasicException basicException)
            {
                statusCode = (basicException.Code != 0) ? basicException.Code : basicException.Number;
                error.Message = basicException.Message;
            }
            else
            {
                statusCode = 500;
                error.Message = $"Ocorreu algum erro durante o processo, por gentileza tente novamente mais tarde.{(string.IsNullOrWhiteSpace(ex.Message) ? "" : " (" + ex.Message + ")")}";
            }

            error.ErrorCode = statusCode.ToString();

            var _objserialized = JsonSerializer.Serialize(error);

            context.Response.Clear();
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(_objserialized);
        }
    }
}

