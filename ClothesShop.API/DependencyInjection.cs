using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using BaseApp.Infrastructure.Settings;

namespace BaseApp.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddControllers();

            // TODO: Add Swagger, CORS, Authentication, etc.

            return services;
        }
    }
}
