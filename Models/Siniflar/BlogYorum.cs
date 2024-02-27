using System.ComponentModel.DataAnnotations;
using songece.Siniflar.Models;

namespace songece.Models.Siniflar
{


    public class BlogYorum{
        public IEnumerable<Blog> Blog1 {get;set;}
        public IEnumerable<Yorumlar> Yorum1 {get;set;}

        public IEnumerable<Blog> BlogTake {get;set;}
        public IEnumerable<Yorumlar> YorumTake {get;set;}

    }
}