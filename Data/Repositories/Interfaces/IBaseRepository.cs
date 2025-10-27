using System.Linq.Expressions;

namespace desenroleApi.Data.Repositories.Interfaces;

public interface IBaseRepository<T> where T : class
{
    Task<T?> GetById<TId>(TId id) where TId : notnull;
    Task<List<T>> GetAll();
    Task<List<T>> Find(Expression<Func<T, bool>> predicate);
    Task<T> Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<bool> Exists<TId>(TId id) where TId : notnull;
    Task SaveChangesAsync();
}