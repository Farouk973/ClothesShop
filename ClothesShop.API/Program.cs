using BaseApp.API;
using BaseApp.API.Settings;
using BaseApp.Application;
using BaseApp.Infrastructure;
using BaseApp.Infrastructure.Settings; // for SwaggerServiceExtensions

var builder = WebApplication.CreateBuilder(args);

// Layers DI
builder.Services.ConfigureApplicationServices();
builder.Services.ConfigureInfrastructureServices(builder.Configuration);
builder.Services.ConfigureApiServices(builder.Configuration);

// Swagger service registration
builder.Services.ConfigureSwaggerServices();

var app = builder.Build();

// Middleware
app.UseSwaggerDocumentation();

app.ConfigureExceptionHandler();
app.MapControllers();

app.Run();
