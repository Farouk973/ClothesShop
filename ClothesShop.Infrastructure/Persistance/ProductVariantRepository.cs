using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Infrastructure.Repositories;


namespace ClothesShop.Infrastructure.Persistance
{
    public class ProductVariantRepository : MongoRepository<ProductVariant>, IProductVariantRepository
    {
        public ProductVariantRepository(IMongoDbContext context) : base(context) { }
    }
}
