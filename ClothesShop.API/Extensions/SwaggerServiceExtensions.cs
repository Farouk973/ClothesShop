using Microsoft.OpenApi.Models;

namespace ClothesShop.API.Settings
{
    public static class SwaggerServiceExtensions
    {
        // Registers Swagger services
        public static IServiceCollection ConfigureSwaggerServices(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Shop API",
                    Version = "v1",
                    Description = "API for the Clothes Shop App"
                });
            });

            return services;
        }
    }
}
