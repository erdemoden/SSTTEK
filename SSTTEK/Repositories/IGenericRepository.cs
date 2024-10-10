using System.Linq.Expressions;
using SSTTEK.Entity;

namespace SSTTEK.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<T> Add(T entity);
    Task<T> Update(T entity);
    Task<T> GetById(int id);
    void Remove(T entity);
    IQueryable<T> GetAll();
    IQueryable<T> Where(Expression<Func<T, bool>> expression);
    Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
}