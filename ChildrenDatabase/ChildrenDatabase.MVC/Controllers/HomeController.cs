using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChildrenDatabase.MVC.Models;

namespace ChildrenDatabase.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        var model = new List<Child>()
        {
            new Child ()
            {
                FirstName = "Tomek",
                LastName = "Kot"
            }
        };
        return View(model);
    }

    public IActionResult About()
    {
        var model = new About()
        {
            Title = "Preschool children",
            Description = "Database of children attending our prechool",
            Tags = new List<string> { "children", "preschool", "kindergarten" }
        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
