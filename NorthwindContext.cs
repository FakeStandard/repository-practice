using Microsoft.EntityFrameworkCore;
using repository_practice.Models;

namespace repository_practice
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<OrderDetail>()
                .ToTable("OrderDetails")
                .HasKey(k => new { k.OrderID, k.ProductID });
        }
    }
}
