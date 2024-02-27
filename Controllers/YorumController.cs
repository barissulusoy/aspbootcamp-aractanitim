using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using songece.Data.Abstract;
using songece.Models;
using songece.Models.Siniflar;

namespace songece.Controllers;

public class YorumController : Controller

{
    private readonly ICommentRepository _commentRepository;
        public YorumController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }


        public async Task<IActionResult> Index(){
            return View();
        }




        public IActionResult YorumYap()
        {

        return View();
        }

        [HttpPost]
        public IActionResult YorumYap (int Blogid,string? Yorum)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var username = User.FindFirstValue(ClaimTypes.Name);
            var userMail = User.FindFirstValue(ClaimTypes.Email);
            

            var entity = new Yorumlar {
                KullaniciAdi=username,
                Mail=userMail,
                Blogid=Blogid,
                Yorum = Yorum,
                Userid = int.Parse(userId ?? "")
            };
            _commentRepository.CreateComment(entity);
            return RedirectToAction("BlogDetay", "Blog", new { id = Blogid });
}
}