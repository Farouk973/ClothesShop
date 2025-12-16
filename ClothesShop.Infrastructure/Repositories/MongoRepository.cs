using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Infrastructure.Data;
using MongoDB.Driver;
using System.Linq.Expressions;


namespace ClothesShop.Infrastructure.Repositories
{
    public class MongoRepository<T> : IRepository<T> where T : class
    {
        private readonly IMongoCollection<T> _collection;

        public MongoRepository(IMongoDbContext context)
        {
            _collection = context.GetCollection<T>(typeof(T).Name);
        }

        // Basic CRUD
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

        // Optional helpers for Products/Variants
        public async Task<T?> GetByReferenceAsync(int reference)
        {
            return await _collection.Find(Builders<T>.Filter.Eq("Reference", reference)).FirstOrDefaultAsync();
        }
    }
}
