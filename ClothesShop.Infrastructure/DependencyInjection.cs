using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Infrastructure.Data;
using ClothesShop.Infrastructure.Persistance;
using ClothesShop.Infrastructure.Repositories;
using ClothesShop.Infrastructure.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;


public static class DependencyInjection
{
    public static IServiceCollection ConfigureInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // 1. MongoDB settings
        services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));

        // Bind MongoDbSettings to an interface to keep Clean Architecture purity
        services.AddSingleton<IMongoDbSettings>(sp =>
            sp.GetRequiredService<IOptions<MongoDbSettings>>().Value);

        // 2. MongoDB context
        services.AddSingleton<IMongoDbContext, MongoDbContext>();
        services.AddScoped<IDatabaseSeeder, MongoDbSeeder>();

        // 3. Generic repository
        services.AddScoped(typeof(IRepository<>), typeof(MongoRepository<>));
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductVariantRepository, ProductVariantRepository>();
        services.AddScoped<IImageRepository, ImageRepository>();
        services.AddScoped<IVideoRepository, VideoRepository>();
        services.AddScoped<IPromotionRepository, PromotionRepository>();
        


        return services;
    }
}