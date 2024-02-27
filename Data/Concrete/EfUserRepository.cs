
using songece.Data;
using songece.Data.Concrete;
using songece.Models;
using songece.Models.Siniflar;
using songece.Siniflar.Models;
using songece.Data.Abstract;

namespace songece.Data.Concrete
{
    public class EfUserRepository : IUserRepository

    {
        private BlogContext _context;
        public EfUserRepository(BlogContext context)
        {
            _context = context;
        }
        public IQueryable<User> Users => _context.Users;

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}