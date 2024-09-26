using Microsoft.AspNetCore.Mvc;
using SSTTEK.Entity;
using SSTTEK.Services;

namespace SSTTEK.Controllers;
[Route("api/books")]
public class BookController(IBookService bookService) : Controller
{

    [HttpGet("getDetailOfBook")]
    public IActionResult Detail(int id)
    {
        return View(bookService.getBookById(id));
    }
}