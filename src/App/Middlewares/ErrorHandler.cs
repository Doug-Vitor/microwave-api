using System.Net;

public class ErrorHandlerMiddleware
{
  private readonly RequestDelegate _next;

  private static readonly Dictionary<Type, ErrorResponseDTO> SupportedExceptions = new()
  {
    {
      typeof(DuplicatedSymbolException),
      new((int)HttpStatusCode.UnprocessableEntity, DuplicatedSymbolException.Message)
    }
  };

  public ErrorHandlerMiddleware(RequestDelegate next) => _next = next;

  public async Task InvokeAsync(HttpContext context)
  {
    try
    {
      await _next(context);
    }
    catch (Exception error)
    {
      await HandleExceptionAsync(context, error);
    }
  }

  private Task HandleExceptionAsync(HttpContext context, Exception exception)
  {
    var response = SupportedExceptions.GetValueOrDefault(
      exception.GetType(),
      new((int)HttpStatusCode.InternalServerError, "Ocorreu um erro interno.")
    );

    context.Response.ContentType = "application/json";
    context.Response.StatusCode = response.StatusCode;

    return context.Response.WriteAsync(response.ToJson());
  }
}