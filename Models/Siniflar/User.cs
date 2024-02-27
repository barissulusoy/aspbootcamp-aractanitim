using System.ComponentModel.DataAnnotations;
using songece.Models.Siniflar;

namespace songece.Siniflar.Models
{
    public class User{
        [Key]
        public int Id {get;set;}
        
        public string? UserName {get;set;}
        public string? NameSurname {get;set;}

        public string? Email {get;set;}
        public string? Password {get;set;}
        public string? Image {get;set;}

        public DateTime CreationDate {get;set;}

        public ICollection<Yorumlar> ?Yorumlars {get;set;}
        public ICollection<Blog> ?Blogs {get;set;}

        

    }
}