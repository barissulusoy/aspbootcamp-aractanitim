using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using songece.Models;

namespace songece.Controllers;

public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
     public IActionResult About()
    {
        return View();
    }
}
