using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Infrastructure.Repositories;


namespace ClothesShop.Infrastructure.Persistance
{
    public class VideoRepository : MongoRepository<Video>, IVideoRepository
    {
        public VideoRepository(IMongoDbContext context) : base(context) { }
    }
}
