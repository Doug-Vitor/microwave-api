using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjectionConfiguration
{
  public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    => services.AddDatabase().AddServices();

  static IServiceCollection AddDatabase(this IServiceCollection services)
    => services.AddDbContext<AppDbContext>((sp, options) =>
    {
      options.UseNpgsql(Environment.GetEnvironmentVariable(Constants.DatabaseConnectionString));
    });

  static IServiceCollection AddServices(this IServiceCollection services)
    => services.AddScoped(typeof(IWritableRepository<>), typeof(WritableRepository<>))
               .AddScoped(typeof(IReadonlyRepository<>), typeof(ReadonlyRepository<>))
               .AddScoped<AppDbSeeder>();
}