using SSTTEK.Entity;

namespace SSTTEK.Repositories;

public interface IBooksRepository
{
    List<Books> getAllBooks();
    
    Books getBookById(int id);
    
    int getBiggestId();
    
    Books save (Books books);
}