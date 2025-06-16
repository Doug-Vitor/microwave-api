public static class MiddlewareConfiguration
{
  internal static IApplicationBuilder UseMiddlewares(this IApplicationBuilder application) =>
    application.UseMiddleware<ErrorHandlerMiddleware>();
}