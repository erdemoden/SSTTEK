using AutoMapper;
using SSTTEK.DTO;
using SSTTEK.Entity;
using SSTTEK.Repositories;

namespace SSTTEK.Services
{

    public class BooksService(IBooksRepository booksRepository,IMapper mapper) : IBookService
    {
        
        public List<Books> getAllBooks()
        {
           return  booksRepository.getAllBooks();
        }

        public Books getBookById(int id)
        {
            return booksRepository.getBookById(id);
        }

        public Books save(SaveUpdateBookDTO book)
        {
            Books books = mapper.Map<SaveUpdateBookDTO, Books>(book);
            books.Id = booksRepository.getBiggestId()+1;
            return booksRepository.save(books);
        }

        public Books update(Books books)
        {
            return booksRepository.save(books);
        }
    }
}