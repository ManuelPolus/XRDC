using Microsoft.EntityFrameworkCore;

namespace XRDC.DAL
{
    public class DataContext<T> : DbContext where T : class
    {
        public DataContext(DbContextOptions<DataContext<T>> options) : base(options)
        {

        }

        public DataContext()
        {

        }

        public DbSet<T> Data { get; set; }


    }
}
