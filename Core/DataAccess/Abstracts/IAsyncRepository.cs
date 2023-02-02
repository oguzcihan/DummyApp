using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess.Abstracts
{
    public interface IAsyncRepository<T> : IQuery<T> where T : Entity
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        //Task<IList<T>> GetList(Expression<Func<T, bool>> filter = null);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
