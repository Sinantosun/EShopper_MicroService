using EShopper.Catalog.Entities;
using System.Linq.Expressions;

namespace EShopper.Catalog.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetFilteredListAsync(Expression<Func<T, bool>> filter);
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task<T> GetByIdAsync(string id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(string id);




    }
}
