# Microwave API

## Features
- Create and update warms
- Default presets
- Custom presets
- Create a warm from a preset

## Running locally
 - Dotnet 9.0 and PostgreSQL are required;
 - Fill up your environment file with your postgres database url, in the `DATABASE_CONNECTION_STRING` key, e.g `DATABASE_CONNECTION_STRING="Host=localhost;Port=5432;Database=microwave"`;
 - Build the solution with `dotnet build` command;
 - Create your database and run the migrations with the `dotnet ef database update --project src/Infra --startup-project src/App` command;
 - Run the app with the `dotnet run` command

## Next steps (may never be taken)
- [ ] Authentication and authorization