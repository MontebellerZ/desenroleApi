using System.Linq.Expressions;
using desenroleApi.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace desenroleApi.Data.Repositories;

public class BaseRepository<T>(Context context) : IBaseRepository<T> where T : class
{
    protected readonly Context _context = context;
    protected readonly DbSet<T> _dbSet = context.Set<T>();

    public virtual async Task<T?> GetById(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task<T?> GetById(Guid id)
    {
        return await _dbSet.FindAsync(id);
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

    public virtual async Task<bool> Exists(int id)
    {
        return await _dbSet.FindAsync(id) != null;
    }

    public virtual async Task<bool> Exists(Guid id)
    {
        return await _dbSet.FindAsync(id) != null;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}