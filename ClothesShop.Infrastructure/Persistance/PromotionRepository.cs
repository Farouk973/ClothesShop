using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Entities;
using ClothesShop.Infrastructure.Repositories;


namespace ClothesShop.Infrastructure.Persistance
{
    public class PromotionRepository : MongoRepository<Promotion>, IPromotionRepository
    {
        public PromotionRepository(IMongoDbContext context) : base(context) { }
    }
}