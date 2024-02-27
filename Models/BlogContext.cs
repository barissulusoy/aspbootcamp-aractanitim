using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using songece.Models.Siniflar;
using songece.Siniflar.Models;

namespace songece.Models.Siniflar
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {
        }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options){}
        public DbSet<Admin> Admins => Set<Admin>();

        public DbSet<Adres> Adress => Set<Adres>();
        public DbSet<Hakkimizda> Hakkimizdas => Set<Hakkimizda>();

        public DbSet<Blog> Blogs => Set<Blog>();
        public DbSet<İletisim> İletisims => Set<İletisim>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Yorumlar> Yorumlars => Set<Yorumlar>();
   


    }
}