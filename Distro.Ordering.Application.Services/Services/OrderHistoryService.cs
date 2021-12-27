using Distro.Ordering.DataAccess;
using Distro.Ordering.DataAccess.Repositories;
using Distro.Ordering.Domain.Contracts;
using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.Application.Services
{
    /// <summary>
    /// !!! No domain logic !!!
    /// In Clean Architecture this is the User Story entry definitions,in DDD the logic resides in the domain one level lower.
    /// (a) Search for entities through repo
    /// (a) Interact with a specific entity through its behaviors
    /// (b) Call a domain service to more complex domain opperations
    /// </summary>
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
