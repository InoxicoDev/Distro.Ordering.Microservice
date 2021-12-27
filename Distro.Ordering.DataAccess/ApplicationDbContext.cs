
using Distro.Ordering.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Distro.Ordering.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrdersItems { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // This needs to be cleaned up, most propably each table have its own configuration class i.e. EntityTypeConfiguration

            // Primary Keys
            builder.Entity<Order>()
              .HasKey(k => k.Id);
            builder.Entity<Product>()
              .HasKey(k => k.Id);
            builder.Entity<OrderItem>()
                .HasKey(n => new { n.Id, n.OrderId, n.ProductId });

            // Navigation properties
            builder.Entity<OrderItem>()
               .HasOne(n => n.Order)
               .WithMany(c => c.Items)
               .HasForeignKey(o => o.OrderId);

            // Navigation properties
            builder.Entity<OrderItem>()
               .HasOne(n => n.Product)
               .WithMany(n => n.OrderItems)
               .HasForeignKey(o => o.ProductId);

            // Ignore the Value Object only persist the value
            // builder.Entity<Order>().Ignore(v => v.OrderNumber);
            builder.Entity<Order>()
              .Property(o => o.Price)
              .HasColumnType("decimal(18, 2)");

            builder.Entity<Order>()
                .HasIndex(o => o.OrderNumber)
                .IsUnique();
        }
    }
}