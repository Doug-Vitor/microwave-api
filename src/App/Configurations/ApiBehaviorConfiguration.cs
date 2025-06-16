internal static class ApiBehaviurConfiguration
{
  internal static IServiceCollection AddApiBehavior(this IServiceCollection services)
  {
    services.AddControllers();
    services.ConfigureCors();
    return services;
  }

  static IServiceCollection ConfigureCors(this IServiceCollection services)
  {
    services.AddCors(options =>
      options.AddPolicy(Constants.LocalCors, policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader())
    );

    return services;
  }
}