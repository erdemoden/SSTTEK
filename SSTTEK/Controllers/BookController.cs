using Microsoft.AspNetCore.Mvc;
using SSTTEK.DTO;
using SSTTEK.Entity;
using SSTTEK.Models;
using SSTTEK.Services;

namespace SSTTEK.Controllers;

public class BookController(IBookService bookService) : Controller
{
    [HttpGet("/book/create")]
    public IActionResult Create()
    {
        return View();
    }

    public async Task<IActionResult> AllBooks()
    {
        var books = await bookService.getAllBooks();
        return View("/Views/Home/AllBooks.cshtml", books);
    }

    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        return View(await bookService.getBookById(id));
    }

    [HttpGet("getDetailOfBook")]
    public async Task<IActionResult> Detail(int id)
    {
        return View(await bookService.getBookById(id));
    }

    [HttpPost]
    public async Task<IActionResult> Create(SaveUpdateBookDTO saveUpdateBookDto)
    {
        if (!ModelState.IsValid)
        {
            return View(saveUpdateBookDto);
        }

        await bookService.save(saveUpdateBookDto);
        return RedirectToAction("AllBooks");
    }

    [HttpPost]
    public IActionResult Update(Books books)
    {
        if (!ModelState.IsValid)
        {
            return View(books);
        }

        bookService.update(books);
        return RedirectToAction("AllBooks");
    }
    [HttpPost]
    public async Task<IActionResult> Search(string searchTerm)
    {
        var books = await bookService.searchBooks(searchTerm);
        return View("/Views/Home/AllBooks.cshtml", books);
    }
}