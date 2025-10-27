using System.Linq.Expressions;
using desenroleApi.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace desenroleApi.Data.Repositories;

public class BaseRepository<T>(Context context) : IBaseRepository<T> where T : class
{
    protected readonly Context _context = context;
    protected readonly DbSet<T> _dbSet = context.Set<T>();

    public virtual async Task<T?> GetById<TId>(TId id) where TId : notnull
    {
        var entity = await _dbSet.FindAsync(id);
        return entity;
    }

    public virtual async Task<List<T>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }

    public virtual async Task<List<T>> Find(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }

    public virtual async Task<T> Add(T entity)
    {
        var entry = await _dbSet.AddAsync(entity);
        return entry.Entity;
    }

    public virtual async Task Update(T entity)
    {
        _dbSet.Update(entity);
        await Task.CompletedTask;
    }

    public virtual async Task Delete(T entity)
    {
        _dbSet.Remove(entity);
        await Task.CompletedTask;
    }

    public virtual async Task<bool> Exists<TId>(TId id) where TId : notnull
    {
        var entity = await _dbSet.FindAsync(id);
        return entity != null;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}