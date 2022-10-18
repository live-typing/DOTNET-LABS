using Microsoft.EntityFrameworkCore;

namespace firstapi.Data
{
    public class FirstApiContext:DbContext
    {
        public DbSet<Emp>Employees { get; set; }

        public FirstApiContext(DbContextOptions<FirstApiContext> options)
            : base(options)
        {
        }

    }
}
