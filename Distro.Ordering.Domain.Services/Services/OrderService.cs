using Distro.Ordering.Domain.Entities;
using Distro.Ordering.Domain.Contracts.Repositories;
using Distro.Ordering.Domain.Contracts;
using Distro.Ordering.Domain.Behaviors;

namespace Distro.Seedworks.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order AddOrder(Order order)
        {
            _orderRepository.Add(order);

            return order;
        }

        public Order GetOrderById(Guid id)
        {
            var order = _orderRepository.GetById(id);

            return order;
        }

        public Order UpdateOrder(Order order)
        {
            var existingOrder = _orderRepository.GetById(order.Id);

            existingOrder?.Behaviors?.Update(order);

            return existingOrder;
        }
    }
}
