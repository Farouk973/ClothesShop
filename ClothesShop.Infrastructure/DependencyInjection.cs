using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using BaseApp.Application.Persistence;
using BaseApp.Infrastructure.Persistance;
using BaseApp.Infrastructure.Settings;
using Microsoft.Extensions.Options;


namespace BaseApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITodoRepository, TodoRepository>();

            // MongoDB settings
            services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));
            services.AddSingleton<IMongoDbSettings>(sp =>
                sp.GetRequiredService<IOptions<MongoDbSettings>>().Value);


            return services;
        }
    }
}
