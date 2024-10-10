using SSTTEK.DTO;
using SSTTEK.Entity;

namespace SSTTEK.Services;

public interface IBookService
{
    Task<List<Books>> getAllBooks();
    
    Task<Books> getBookById(int id);

    Task<Books> save(SaveUpdateBookDTO book);
    
    Task<Books> update(Books book);
    Task<List<Books>> searchBooks(string search);
}