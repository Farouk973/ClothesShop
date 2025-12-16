using ClothesShop.Domain.Entities;
using ClothesShop.Entities;
using System.Linq.Expressions;

namespace ClothesShop.Application.Common.Interfaces
{
    public interface IRepository<T>
    {
        Task<T?> GetByIdAsync(string id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task UpdateAsync(string id, T entity);
        Task DeleteAsync(string id);
    }
    public interface ICategoryRepository : IRepository<Category> { }
    public interface IProductRepository : IRepository<Product> { }
    public interface IProductVariantRepository : IRepository<ProductVariant> { }
    public interface IImageRepository : IRepository<Image> { }
    public interface IVideoRepository : IRepository<Video> { }
    public interface IPromotionRepository : IRepository<Promotion> { }
}
