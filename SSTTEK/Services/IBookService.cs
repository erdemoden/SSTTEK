using SSTTEK.DTO;
using SSTTEK.Entity;

namespace SSTTEK.Services;

public interface IBookService
{
    List<Books> getAllBooks();
    
    Books getBookById(int id);

    Books save(SaveUpdateBookDTO book);
    
    Books update(Books book);
}