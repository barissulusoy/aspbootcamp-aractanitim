using System.ComponentModel.DataAnnotations;

namespace songece.Models.Siniflar
{
    public class Hakkimizda{
        [Key]
        public int Id {get;set;}
        
        public string? FotoUrl {get;set;}
        public string? Aciklama {get;set;}

    

    }
}