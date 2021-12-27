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
    public class DatabaseInitializationTests : DbTestsBase<ApplicationDbContext>
    {
        private OrderRepository _orderRepo;
        private ProductRepository _productRepo;

        public DatabaseInitializationTests() : base("DefaultConnection")
        {
            _orderRepo = new OrderRepository(_context);
            _productRepo = new ProductRepository(_context);
        }

        [Fact(Skip = "This is an sample test")]
        public void SampleTest()
        {
            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, TimeSpan.MaxValue, TransactionScopeAsyncFlowOption.Enabled))
            {
                var bicPens = _productRepo.Add(new ProductBuilder().BicPen().Build());
                var paper = _productRepo.Add(new ProductBuilder().A4Paper().Build());
                _context.SaveChanges();

                var newOrder = new OrderBuilder().SampleOrder()
                    .AddOrderItem(bicPens, 3)
                    .AddOrderItem(paper, 10)
                    .Build();

                _orderRepo.Add(newOrder);
                _context.SaveChanges();

                scope.Complete();
            }
        }
    }
}