
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

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

//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//{
//    var configuration = new ConfigurationBuilder()
//        .SetBasePath(Directory.GetCurrentDirectory())
//        .AddJsonFile("appsettings.json")
//        .Build();

//    var connectionString = configuration.GetConnectionString("DefaultConnection");
//    optionsBuilder.UseSqlServer(connectionString);
//}