using MongoDB.Driver;

namespace ClothesShop.Application.Common.Interfaces
{
    public interface IMongoDbContext
    {
        IMongoCollection<T> GetCollection<T>(string name);

    }

}
