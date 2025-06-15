internal static class DefaultConfiguration
{
  internal static IServiceCollection AddDefaultConfigurations(this IServiceCollection services)
    => services.AddApiBehavior().AddInfrastructureServices().AddServices();

  internal static WebApplication UseDefaultConfigurations(this WebApplication app)
  {
    app.MapControllers();
    app.UseCors(app.Environment.IsProduction() ? "" : Constants.LocalCors).UseAuthentication();
    return app;
  }
}