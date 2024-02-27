using songece.Data.Abstract;
using songece.Models.Siniflar;


namespace songece.Data.Concrete
{
    public class EfCommentRepository : ICommentRepository
    {
        private BlogContext _context;
        public EfCommentRepository(BlogContext context)
        {
            _context = context;
        }
        public IQueryable<Yorumlar> Yorumlars => _context.Yorumlars;

        public void CreateComment(Yorumlar comment)
        {
            _context.Yorumlars.Add(comment);
            _context.SaveChanges();
        }
    }
}