using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using songece.Models;

namespace songece.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}