using DevExpress.CodeParser;
using Microsoft.EntityFrameworkCore;
using SellerOps.DevExpress.Inventory.Wpf.Models;

namespace SellerOps.DevExpress.Inventory.Wpf.Data
{
    public sealed class InventoryDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=inventory.db");
        }
    }
}
