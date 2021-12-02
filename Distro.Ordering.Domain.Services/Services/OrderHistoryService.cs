using Distro.Ordering.Domain.Contracts;
using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.Domain.Services.Services
{
    public class OrderHistoryService : IOrderHistoryService
    {
        private IRepository<Order> _orderRepository;

        public OrderHistoryService(IRepository<Order> repository)
        {
            _orderRepository = repository;
        }

        public IEnumerable<Order> GetOrderHistory(Guid customerId)
        {
            return _orderRepository.FindAll().Where(t => t.CustomerId == customerId);
        }
    }
}
