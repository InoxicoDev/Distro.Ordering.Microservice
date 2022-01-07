using Distro.Ordering.Domain.Entities;
using Distro.Ordering.Domain.Contracts;
using Distro.Ordering.Domain.Behaviours;
using Distro.Ordering.DataAccess;
using Distro.Ordering.DataAccess.Repositories;
using Distro.Ordering.Domain.Contracts.Repositories;

namespace Distro.Ordering.Application.Services
{
    /// <summary>
    /// !!! No domain logic !!!
    /// In Clean Architecture this is the User Story entry definitions,in DDD the logic resides in the domain one level lower.
    /// (a) Search for entities through repo
    /// (a) Interact with a specific entity through its behaviors
    /// (b) Call a domain service to more complex domain opperations
    /// </summary>
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order AddOrder(Order order)
        {
            var addedOrder = _orderRepository.Add(order);
            addedOrder?.Behaviours()?.Add(order);

            return addedOrder;
        }

        public Order GetOrderById(Guid id)
        {
            var order = _orderRepository.GetById(id);
            return order;
        }

        public Order UpdateOrder(Order order)
        {
            var existingOrder = _orderRepository.GetById(order.Id);
            existingOrder?.Behaviours()?.Update(order);

            return existingOrder;
        }
    }
}
