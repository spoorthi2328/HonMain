using HonMain.Models;

namespace HonMain.repos
{
    public interface IRepositoryInterface
    {
        Task<IEnumerable<BookDetail>> GetBookDetails();
        Task<BookDetail?> GetBookDetail(int id);

        bool AddBookDetail(BookDetail bookDetail);

        bool DeleteBook(int id);


    }
}
