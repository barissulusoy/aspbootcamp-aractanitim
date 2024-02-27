using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using songece.Models;
using songece.Models.Siniflar;

namespace songece.Controllers;

public class AdminController : Controller
{
    private readonly BlogContext _context;
    public AdminController(BlogContext context)
    {
        _context = context;
    }
    BlogYorum by=new BlogYorum();

    public IActionResult Index(){
        var degerler=_context.Blogs.ToList();
    return View(degerler);}

    [HttpGet]
    public IActionResult YeniBlog(){  
    return View();}
     
     [HttpPost]
    public IActionResult YeniBlog(Blog p){
        _context.Blogs.Add(p);
        _context.SaveChanges();
    
    return RedirectToAction("Index");}
    public IActionResult BlogSil(int id){
        var b =_context.Blogs.Find(id);
        _context.Blogs.Remove(b!);
        _context.SaveChanges();
    return RedirectToAction("Index");}

    public IActionResult BlogGetir(int id){
        var bl =_context.Blogs.Find(id);
        return View("BlogGetir",bl); }

    public IActionResult BlogGuncelle(Blog b){
        var blg =_context.Blogs.Find(b.Id);
        blg.Aciklama=b.Aciklama;
        blg.Baslik=b.Baslik;
        blg.BlogImage=b.BlogImage;
        blg.Tarih=b.Tarih;
        _context.SaveChanges();
        return RedirectToAction("Index");}

    public IActionResult YorumListesi()
    {
        var yorumlar=_context.Yorumlars.ToList();
        return View(yorumlar);
    }

        public IActionResult YorumSil(int Id){
        var bb =_context.Yorumlars.Find(Id);
        _context.Yorumlars.Remove(bb!);
        _context.SaveChanges();
        return RedirectToAction("YorumListesi");}


        public IActionResult YorumGetir(int id){
        var yr =_context.Yorumlars.Find(id);
        return View("YorumGetir",yr); }

    public IActionResult YorumGuncelle(Yorumlar y){
        var yrm =_context.Yorumlars.Find(y.Id);
        yrm.Yorum=y.Yorum;
        _context.SaveChanges();
        return RedirectToAction("YorumListesi");}

}

