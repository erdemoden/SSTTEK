using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SSTTEK.Models;
using SSTTEK.Services;

namespace SSTTEK.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBookService bookService;

    public HomeController(ILogger<HomeController> logger,IBookService bookService)
    {
        _logger = logger;
        this.bookService = bookService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult AllBooks()
    {
        return View(bookService.getAllBooks());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}