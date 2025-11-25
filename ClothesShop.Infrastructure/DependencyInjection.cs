using ClothesShop.Infrastructure.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ClothesShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // MongoDB settings
            services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));
            services.AddSingleton<IMongoDbSettings>(sp =>
                sp.GetRequiredService<IOptions<MongoDbSettings>>().Value);

            // TODO: uncomment when repositories are implemented
            // services.AddScoped<IUserRepository, UserRepository>();
            // services.AddScoped<ITodoRepository, TodoRepository>();

            return services;
        }
    }
}