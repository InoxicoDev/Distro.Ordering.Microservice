using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Contracts
{
    public interface IOrderHistoryService : IApplicationService
    {
        public IEnumerable<Order> GetOrderHistory(Guid customerId);

        public IEnumerable<Order> DelayPendingOrdersWithSpecificItem(Guid orderItemId, int days);
    }
}
