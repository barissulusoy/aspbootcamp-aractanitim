
using songece.Models.Siniflar;

namespace songece.Data.Abstract
{
    public interface ICommentRepository
    {
        IQueryable<Yorumlar> Yorumlars { get; }
        void CreateComment(Yorumlar Yorumlar);
    }
}