namespace desenroleApi.Services.Interfaces;

public interface IBaseService<T> where T : class
{
    Task<T?> GetById<TId>(TId id) where TId : notnull;
    Task<IEnumerable<T>> GetAll();
    Task<T> Create(T entity);
    Task Update(T entity);
    Task Delete<TId>(TId id) where TId : notnull;
}