using System.ComponentModel.DataAnnotations;

namespace songece.Models.Siniflar
{
    public class Anasayfa{
        [Key]
        public int Id {get;set;}
        
        public string? Baslik {get;set;}
        public string? Aciklama {get;set;}

    

    }
}