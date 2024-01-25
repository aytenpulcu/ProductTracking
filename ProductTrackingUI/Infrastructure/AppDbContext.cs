using Microsoft.EntityFrameworkCore;
using ProductTrackingUI.Models;

namespace ProductTrackingUI.Infrastructure
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
          
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
     
    }
}
