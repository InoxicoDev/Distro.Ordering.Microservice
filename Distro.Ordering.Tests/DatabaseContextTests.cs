using Distro.Ordering.DataAccess;
using Distro.Ordering.DataAccess.Repositories;
using Distro.Ordering.Tests.Builders;
using Distro.Seedworks.Infrastructure.DataAccess;
using Xunit;

namespace Distro.Ordering.Tests
{
    public class DatabaseContextTests : DbTestsBase<ApplicationDbContext>
    {
        private OrderRepository _orderRepo;

        public DatabaseContextTests() : base("DefaultConnection")
        {

            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                   
            //_context = new ApplicationDbContext(optionsBuilder.Options);
            //_transaction = new TransactionScope(TransactionScopeOption.RequiresNew, TimeSpan.MaxValue);

            _orderRepo = new OrderRepository(_context);
        }


        [Fact(Skip = "This is an sample test")]
        public void SampleTest()
        {
            //Arrange
            //Act
            //Assert
        }

        [Fact]
        public void DatabaseAddTest()
        {
            var newOrder = new OrderBuilder().SampleOrder().Build();
            var response = _orderRepo.Add(newOrder);
            Assert.NotNull(response);
        }
    }
}