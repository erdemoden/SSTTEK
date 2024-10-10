namespace SSTTEK.Repositories;

public interface IUnitOfWork
{
    Task<int> Commit();
}