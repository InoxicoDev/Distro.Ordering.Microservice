using Distro.Ordering.Domain.Contracts.Entities;
using Distro.Seedworks.Domain.Services;

namespace Distro.Ordering.Domain.Contracts.Services
{
    public interface IOrderService : IDomainService
    {
        public Order GetOrderById();

        public Order AddOrder(Order order);

        public Order UpdateOrder(Order order);
    }
}
