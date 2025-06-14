DotNetEnv.Env.Load("../../.env");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddInfrastructureServices().AddServices();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
  scope.ServiceProvider.GetRequiredService<AppDbSeeder>().Seed();

app.MapControllers();
app.Run();
