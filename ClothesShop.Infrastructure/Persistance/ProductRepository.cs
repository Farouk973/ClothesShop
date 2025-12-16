using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Infrastructure.Repositories;


namespace ClothesShop.Infrastructure.Persistance
{
    public class ProductRepository : MongoRepository<Product>, IProductRepository
    {
        public ProductRepository(IMongoDbContext context) : base(context) { }
    }
}