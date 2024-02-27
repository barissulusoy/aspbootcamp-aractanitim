using System.ComponentModel.DataAnnotations;
using songece.Siniflar.Models;

namespace songece.Models.Siniflar
{
    public class Blog{
        [Key]
        public int Id {get;set;}
        
        public string? Baslik {get;set;}
        public DateTime Tarih {get;set;}
        public string? Aciklama {get;set;}
        public string? BlogImage {get;set;}
        public ICollection<Yorumlar> ?Yorumlars {get;set;}

        public User ?Users {get;set;}
 


    

    }
}