using Distro.Ordering.DataAccess;
using Distro.Ordering.DataAccess.Repositories;
using Distro.Ordering.Domain.Entities;
using Distro.Ordering.Tests.Builders;
using Distro.Seedworks.Infrastructure.DataAccess;
using System;
using System.Transactions;
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
            Order? response = null;

            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, TimeSpan.MaxValue, TransactionScopeAsyncFlowOption.Enabled))
            {
                var newOrder = new OrderBuilder().SampleOrder().Build();
                response = _orderRepo.Add(newOrder);
                _context.SaveChanges();

                scope.Complete();
            }

            Assert.NotNull(response);
        }
    }
}