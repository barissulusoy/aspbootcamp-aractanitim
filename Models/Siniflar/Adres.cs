using System.ComponentModel.DataAnnotations;

namespace songece.Models.Siniflar
{
    public class Adres{
        [Key]
        public int Id {get;set;}
        
        public string? Baslik {get;set;}
        public string? Aciklama {get;set;}
        public string? AdresAcik {get;set;}
        public string? Telefon {get;set;}
        public string? Konum {get;set;}

    

    }
}