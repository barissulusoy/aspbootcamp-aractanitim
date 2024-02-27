using System.ComponentModel.DataAnnotations;
using songece.Siniflar.Models;

namespace songece.Models.Siniflar
{
    public class Yorumlar{
        [Key]
        public int Id {get;set;}
        
        public string? KullaniciAdi {get;set;}
        public string? Mail {get;set;}
        public string? Yorum {get;set;}
        public int Blogid {get;set;}
        public int Userid {get;set;}
        public virtual Blog ?Blogs {get;set;}
        public virtual User ?Users {get;set;}
 

    }
}