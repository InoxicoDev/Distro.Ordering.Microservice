using Distro.Domain.Common;
using Distro.Ordering.Domain.Entities;

namespace Distro.Ordering.Domain.Contracts
{
    public interface IOrderService : IApplicationService
    {
        public Order? GetOrderById(Guid Id);

        public Order AddOrder(Order order);

        public Order UpdateOrder(Order order);
    }
}
