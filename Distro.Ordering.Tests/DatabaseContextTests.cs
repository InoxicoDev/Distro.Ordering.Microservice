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