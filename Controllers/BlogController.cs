using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using songece.Data.Abstract;
using songece.Models;
using songece.Models.Siniflar;

namespace songece.Controllers;

public class BlogController : Controller

{
    private readonly BlogContext _context;
    public BlogController(BlogContext context)
    {
        _context = context;
    }
    BlogYorum by=new BlogYorum();
    public  IActionResult Index ()
    {
        by.Blog1=_context.Blogs.ToList();
        by.BlogTake=_context.Blogs.Take(2).ToList();
        by.YorumTake=_context.Yorumlars.Take(2).ToList();
        return View(by);
    }


     public  IActionResult BlogDetay(int id)
    {
        
        by.Blog1=_context.Blogs.Where(x=>x.Id==id).ToList();
        by.Yorum1=_context.Yorumlars.Where(y=>y.Blogid==id).ToList();
            if (by.Blog1 == null)
            {
                by.Blog1 = new List<Blog>(); // veya by.Blog1 = Enumerable.Empty<Blog>().ToList();
            }

            if (by.Yorum1 == null)
            {
                by.Yorum1 = new List<Yorumlar>(); // veya by.Yorum1 = Enumerable.Empty<Yorumlar>().ToList();
            }

        return View(by);
    }

         
}