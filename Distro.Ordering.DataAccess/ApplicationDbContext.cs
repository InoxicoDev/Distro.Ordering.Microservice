
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

        public DbSet<Order> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Ignore the Value Object only persist the value
            builder.Entity<Order>().Ignore(v => v.OrderNumber);

        }
    }
}
