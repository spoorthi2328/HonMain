using Microsoft.EntityFrameworkCore;

namespace HonMain.Models
{
    public class DataBaseConetxt:DbContext
    {
        public DataBaseConetxt(DbContextOptions<DataBaseConetxt> options): base(options)
        {
        }

        public DbSet<BookDetail> BookDetail { get; set; }
    }
}
