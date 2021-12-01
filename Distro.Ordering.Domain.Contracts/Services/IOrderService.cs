
using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Contracts.Services
{
    public interface IOrderService : IDomainService
    {
        public Order GetOrderById(Guid Id);

        public Order AddOrder(Order order);

        public Order UpdateOrder(Order order);
    }
}
