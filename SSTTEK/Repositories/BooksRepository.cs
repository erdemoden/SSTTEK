using SSTTEK.Entity;

namespace SSTTEK.Repositories;

public class BooksRepository: IBooksRepository
{
    private List<Books> Books { get; set; }
    
    
    public BooksRepository()
    {
        Books = new List<Books>()
        {
            new Books(1, "denemekitap1", "erdem", "34243fd", 1998, "Dram", "erdem", 12345, "Turkish", "kısa özet"),
            new Books(2, "denemekitap2", "erdem2", "34243fd", 1998, "Dram", "erdem", 12345, "Turkish",
                "kısa özet2"),
            new Books(3, "denemekitap3", "erdem3", "34243fd", 1998, "Dram", "erdem", 12345, "Turkish",
                "kısa özet3"),
        };
    }

    public List<Books> getAllBooks()
    {
        return Books;
    }

    public Books getBookById(int id)
    {
        return Books.FirstOrDefault(b => b.Id == id);
    }

    public int getBiggestId()
    {
        return Books.Max(b => b.Id);
    }

    public Books save(Books books)
    {
        Books.Add(books);
        return books;
    }
    
}