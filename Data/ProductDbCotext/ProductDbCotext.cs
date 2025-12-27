using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.ProductDbCotext
{
    public class ProductDbCotext(DbContextOptions dbContextOptions) : DbContext (dbContextOptions)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
