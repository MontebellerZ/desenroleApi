using desenroleApi.Data.Repositories.Interfaces;
using desenroleApi.Domain.Exceptions;
using desenroleApi.Services.Interfaces;

namespace desenroleApi.Services;

public class BaseService<T>(IBaseRepository<T> repository) : IBaseService<T> where T : class
{
    protected readonly IBaseRepository<T> _repository = repository;

    public virtual async Task<T?> GetById(int id)
    {
        return await _repository.GetById(id);
    }

    public virtual async Task<T?> GetById(Guid id)
    {
        return await _repository.GetById(id);
    }

    public virtual async Task<IEnumerable<T>> GetAll()
    {
        return await _repository.GetAll();
    }

    public virtual async Task<T> Create(T entity)
    {
        var result = await _repository.Add(entity);
        await _repository.SaveChangesAsync();
        return result;
    }

    public virtual async Task Update(T entity)
    {
        await _repository.Update(entity);
        await _repository.SaveChangesAsync();
    }

    public virtual async Task Delete(int id)
    {
        var entity = await _repository.GetById(id) ?? throw new NotFoundException($"Objeto não encontrado com o id {id}");
        await _repository.Delete(entity);
        await _repository.SaveChangesAsync();
    }

    public virtual async Task Delete(Guid id)
    {
        var entity = await _repository.GetById(id) ?? throw new NotFoundException($"Objeto não encontrado com o id {id}");
        await _repository.Delete(entity);
        await _repository.SaveChangesAsync();
    }
}