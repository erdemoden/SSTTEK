using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SSTTEK.Entity;

namespace SSTTEK.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private AppDbContext context;
    private readonly DbSet<T> dbSet;
    public GenericRepository(AppDbContext context)
    {
        this.context = context;
        dbSet = context.Set<T>();
    }

    public async Task<T> Add(T entity)
    {
        await dbSet.AddAsync(entity);
        return entity;
    }

    public async Task<T> Update(T entity)
    {
        dbSet.Update(entity);
        return await Task.FromResult(entity);
    }

    public async Task<T> GetById(int id)
    {
        return await dbSet.FindAsync(id);
    }

    public void Remove(T entity)
    {
        dbSet.Remove(entity);
    }

    public IQueryable<T> GetAll()
    {
        return dbSet.AsNoTracking().AsQueryable();
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> expression)
    {
         return dbSet.Where(expression);
    }

    public Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
    {
       return dbSet.AnyAsync();
    }
}