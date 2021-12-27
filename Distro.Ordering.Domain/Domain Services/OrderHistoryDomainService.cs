using Distro.Ordering.Domain.Contracts.Repositories;
using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Domain_Services
{
    public class OrderHistoryDomainService : IDomainService
    {
        public IOrderRepository OrderRepository { get; set; }

        public OrderHistoryDomainService(IOrderRepository repo)
        {
            OrderRepository = repo;
        }

        public IEnumerable<Order> DelayPendingOrdersWithSpecificItem(Guid orderItemId, int days)
        {
            var orderItem = OrderRepository.GetById(orderItemId);

            // Search for all orders not completed that contains that order ID

            // For each one found call their delay order behavior

            throw new NotImplementedException();
        }

    }
}
