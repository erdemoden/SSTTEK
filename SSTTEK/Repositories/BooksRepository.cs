using SSTTEK.Entity;

namespace SSTTEK.Repositories;

public class BooksRepository(AppDbContext context) : GenericRepository<Books>(context), IBooksRepository
{
}