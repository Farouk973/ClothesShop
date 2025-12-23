using ClothesShop.Application.Common.Interfaces;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace ClothesShop.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly IMongoCollection<T> _collection;

        // Inject the Application-layer interface for MongoDB context
        public BaseRepository(IMongoDbContext context, string collectionName)
        {
            _collection = context.GetCollection<T>(collectionName);
        }

        public async Task<T?> GetByIdAsync(string id)
        {
            return await _collection.Find(Builders<T>.Filter.Eq("Id", id)).FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _collection.Find(predicate).ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(string id, T entity)
        {
            await _collection.ReplaceOneAsync(Builders<T>.Filter.Eq("Id", id), entity);
        }

        public async Task DeleteAsync(string id)
        {
            await _collection.DeleteOneAsync(Builders<T>.Filter.Eq("Id", id));
        }

        public Task<(List<T> Items, int TotalCount)> GetPagedAsync(Expression<Func<T, bool>> filter, int skip, int take)
        {
            throw new NotImplementedException();
        }
    }

}
