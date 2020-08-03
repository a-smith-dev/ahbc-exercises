using Microsoft.EntityFrameworkCore;
using ShoppingListDatabase.Models;

namespace ShoppingListDatabase.Data
{
    public class CartContext : DbContext
    {
        public CartContext(DbContextOptions<CartContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(e =>
            {
                e.Property(x => x.Name)
                    .HasMaxLength(50)
                    .IsRequired();

                e.Property(x => x.Price)
                    .IsRequired();
            });
        }
    }
}
