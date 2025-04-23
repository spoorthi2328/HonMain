using HonMain.Models;
using Microsoft.EntityFrameworkCore;

namespace HonMain.repos
{
    public class IRepositoryClass: IRepositoryInterface
    {
        private readonly DataBaseConetxt _context;
        public IRepositoryClass(DataBaseConetxt context)
        {
            _context = context;
        }
       public bool AddBookDetail(BookDetail bookDetail)
        {
            _context.BookDetail.Add(bookDetail);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool DeleteBook(int id)
        {
           _context.BookDetail.Remove(_context.BookDetail.Find(id));
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public async Task<BookDetail?> GetBookDetail(int id)
        {
            var res= await _context.BookDetail.FindAsync(id);
            return res;
        }
        public async Task<IEnumerable<BookDetail>> GetBookDetails()
        {
           
          return  await _context.BookDetail.ToListAsync();
            
        }
    }
    
    
}
