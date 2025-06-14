using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjectionConfiguration
{
  public static IServiceCollection AddServices(this IServiceCollection services)
    => services.AddScoped<IWarmServices, WarmServices>();
}