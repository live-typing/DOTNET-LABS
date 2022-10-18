using Microsoft.EntityFrameworkCore;

namespace Labintegration1.Data1
{
    public class labintegration1Context : DbContext
    {
        public labintegration1Context(DbContextOptions<labintegration1Context> options)
           : base(options)
        {
        }
    }
}
