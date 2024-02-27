using System.ComponentModel.DataAnnotations;

namespace songece.Models.Siniflar
{
    public class İletisim{
        [Key]
        public int Id {get;set;}
        
        public string? AdSoyad {get;set;}
        public string? Mail {get;set;}
        public string? Konu {get;set;}
        public string? Mesaj {get;set;}

    

    }
}