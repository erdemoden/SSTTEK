using Microsoft.AspNetCore.Mvc;
using SSTTEK.DTO;
using SSTTEK.Entity;
using SSTTEK.Models;
using SSTTEK.Services;

namespace SSTTEK.Controllers;
public class BookController(IBookService bookService) : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    public IActionResult AllBooks()
    {
        var books = bookService.getAllBooks();
        return View("/Views/Home/AllBooks.cshtml", books);
    }
    
    [HttpGet]
    public IActionResult Update(int id)
    {
        return View(bookService.getBookById(id));
    }

    [HttpGet("getDetailOfBook")]
    public IActionResult Detail(int id)
    {
        return View(bookService.getBookById(id));
    }

    [HttpPost]
    public IActionResult Create(SaveUpdateBookDTO saveUpdateBookDto)
    {
        if (!ModelState.IsValid)
        {
            return View(saveUpdateBookDto);
        }
        
        bookService.save(saveUpdateBookDto);
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
}