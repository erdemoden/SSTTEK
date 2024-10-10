namespace SSTTEK.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task<int> Commit()
    {
       return  await context.SaveChangesAsync();
    }
}