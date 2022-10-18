using Microsoft.EntityFrameworkCore;

namespace repository_practice
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {

        }
    }
}
