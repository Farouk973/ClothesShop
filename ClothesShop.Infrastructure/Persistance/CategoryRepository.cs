using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Infrastructure.Repositories;

namespace ClothesShop.Infrastructure.Persistance
{
    public class CategoryRepository : MongoRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IMongoDbContext context) : base(context) { }
    }
}