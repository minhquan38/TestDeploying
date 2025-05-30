using Microsoft.EntityFrameworkCore;
using TestDeploying.Models;

namespace TestDeploying
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Models.Product { Id = 1, Name = "Product1", Price = 10.0m },
                new Models.Product { Id = 2, Name = "Product2", Price = 20.0m }
            );
        }
    }
}
