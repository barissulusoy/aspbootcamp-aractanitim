
using songece.Siniflar.Models;

namespace songece.Data.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        void CreateUser(User User);
    }
}