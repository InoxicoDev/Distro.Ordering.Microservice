using Distro.Ordering.DataAccess;
using Distro.Ordering.DataAccess.Repositories;
using Distro.Ordering.Domain.Contracts;
using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.Domain.Services.Services
{
    public class OrderHistoryService : IOrderHistoryService
    {
        private IRepository<Order> _orderRepository;

        public OrderHistoryService(ApplicationDbContext context)
        {
            _orderRepository = new OrderRepository(context);
        }

        public IEnumerable<Order> GetOrderHistory(Guid customerId)
        {
            return _orderRepository.FindAll().Where(t => t.CustomerId == customerId);
        }
    }
}
