using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entitys;
using QuickBuy.Domain.Valuables;
using QuickBuy.Repository.Config;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderedItem> OrderedItems { get; set; }
        public DbSet<FormPayment> FormPayments { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FormPaymentConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderedItemConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
