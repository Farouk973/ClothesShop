using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Entities;
using MongoDB.Driver;

namespace ClothesShop.Infrastructure.Data;

public class MongoDbSeeder : IDatabaseSeeder
{
    private readonly IMongoDbContext _context;

    public MongoDbSeeder(IMongoDbContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await SeedCategories();
        await SeedProducts();
        await SeedVariants();
        await SeedPromotions();
    }

    private async Task SeedCategories()
    {
        var collection = _context.GetCollection<Category>("Category");

        if (await collection.EstimatedDocumentCountAsync() > 0)
            return;

        await collection.InsertManyAsync(new[]
        {
            new Category { Name = "Pants", Description = "Casual & formal pants" },
            new Category { Name = "Shirts", Description = "T-shirts and shirts" },
            new Category { Name = "Hats", Description = "Caps and hats" },
            new Category { Name = "Jackets", Description = "Winter jackets" }
        });
    }

    private async Task SeedProducts()
    {
        var categories = _context.GetCollection<Category>("Category");
        var products = _context.GetCollection<Product>("Product");

        if (await products.EstimatedDocumentCountAsync() > 0)
            return;

        var pants = await categories.Find(c => c.Name == "Pants").FirstAsync();

        await products.InsertOneAsync(new Product
        {
            Name = "Classic Jeans",
            Description = "Blue denim jeans",
            Reference = "PANT-001",
            CostPrice = 35,
            SellingPrice = 60,
            CategoryId = pants.Id,
            InStock = true
        });
    }

    private async Task SeedVariants()
    {
        var products = _context.GetCollection<Product>("Product");
        var variants = _context.GetCollection<ProductVariant>("ProductVariant");

        if (await variants.EstimatedDocumentCountAsync() > 0)
            return;

        var jeans = await products.Find(p => p.Name == "Classic Jeans").FirstAsync();

        await variants.InsertManyAsync(new[]
        {
            new ProductVariant
            {
                ProductId = jeans.Id,
                Color = "Blue",
                Size = "M",
                Stock = 20
            },
            new ProductVariant
            {
                ProductId = jeans.Id,
                Color = "Black",
                Size = "L",
                Stock = 15
            }
        });
    }

    private async Task SeedPromotions()
    {
        var promotions = _context.GetCollection<Promotion>("Promotion");

        if (await promotions.EstimatedDocumentCountAsync() > 0)
            return;

        await promotions.InsertOneAsync(new Promotion
        {
            Title = "Summer Sale",
            Description = "Buy 2 pants for 110 DT",
            StartDate = DateTime.UtcNow,
            EndDate = DateTime.UtcNow.AddDays(15)
        });
    }
}
