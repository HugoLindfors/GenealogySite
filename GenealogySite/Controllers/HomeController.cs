using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenealogySite.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GenealogySite.Controllers;

public class HomeController : Controller
{
    private readonly GenealogySiteContext _context;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, GenealogySiteContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public async Task<IActionResult> Graph()
    {
        return View(await _context.Person.ToListAsync());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

