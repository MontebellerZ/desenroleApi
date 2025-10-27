namespace desenroleApi.Services.Interfaces;

public interface IBaseService<T> where T : class
{
    Task<T?> GetById(int id);
    Task<T?> GetById(Guid id);
    Task<IEnumerable<T>> GetAll();
    Task<T> Create(T entity);
    Task Update(T entity);
    Task Delete(int id);
    Task Delete(Guid id);
}