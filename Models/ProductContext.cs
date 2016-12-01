using Microsoft.EntityFrameworkCore;

namespace Inventory.Models
{
    class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\inventory;Integrated Security=true;Trusted_Connection=True;");
        }
    }
}