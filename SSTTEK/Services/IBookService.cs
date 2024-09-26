using SSTTEK.Entity;

namespace SSTTEK.Services;

public interface IBookService
{
    List<Books> getAllBooks();
    
    Books getBookById(int id);
}