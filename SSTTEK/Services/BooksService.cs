using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SSTTEK.DTO;
using SSTTEK.Entity;
using SSTTEK.Repositories;

namespace SSTTEK.Services
{

    public class BooksService(IBooksRepository booksRepository,IMapper mapper,IUnitOfWork unitOfWork) : IBookService
    {
        public async Task<List<Books>> getAllBooks()
        {
             return await booksRepository.GetAll().ToListAsync();
        }

        public async Task<Books> getBookById(int id)
        {
            return await booksRepository.GetById(id);
        }

        public async Task<Books> save(SaveUpdateBookDTO book)
        {
            Books books = await booksRepository.Add(mapper.Map<SaveUpdateBookDTO, Books>(book));
            await unitOfWork.Commit();
            return books;
        }

        public async Task<Books> update(Books book)
        {   
            Books books =  await booksRepository.Update(book);
            await unitOfWork.Commit();
            return books;
        }

        public async Task<List<Books>> searchBooks(string search)
        {
            return await booksRepository.Where(b => 
                b.Title.Contains(search) ||
                b.Author.Contains(search) ||
                b.Publisher.Contains(search) ||
                b.Genre.Contains(search)
            ).ToListAsync();
        }
    }
}