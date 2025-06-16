DotNetEnv.Env.Load("../../.env");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDefaultConfigurations();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
  scope.ServiceProvider.GetRequiredService<AppDbSeeder>().Seed();

app.UseDefaultConfigurations();
app.Run();