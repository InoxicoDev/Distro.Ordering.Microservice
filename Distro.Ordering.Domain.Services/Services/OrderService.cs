using Distro.Ordering.Domain.Entities;
using Distro.Ordering.Domain.Contracts;
using Distro.Ordering.Domain.Behaviors;
using Distro.Seedworks.Infrastructure.DataAccess;
using Distro.Ordering.DataAccess;
using Distro.Ordering.DataAccess.Repositories;

namespace Distro.Seedworks.Domain.Services
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;

        public OrderService(ApplicationDbContext context)
        {
            _orderRepository = new OrderRepository(context);
        }

        public Order AddOrder(Order order)
        {
            var addedOrder = _orderRepository.Add(order);
            addedOrder?.Behaviors()?.Add(order);

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
            existingOrder?.Behaviors()?.Update(order);

            return existingOrder;
        }
    }
}
