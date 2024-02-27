using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using songece.Models.Siniflar;

namespace songece.Controllers;

public class AboutController : Controller
{
    private readonly BlogContext _context;
    public AboutController(BlogContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        var degerler=_context.Hakkimizdas.ToList();
        return View(degerler);

    }

}