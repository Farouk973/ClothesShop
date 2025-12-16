using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Infrastructure.Repositories;


namespace ClothesShop.Infrastructure.Persistance
{
    public class ImageRepository : MongoRepository<Image>, IImageRepository
    {
        public ImageRepository(IMongoDbContext context) : base(context) { }
    }
}