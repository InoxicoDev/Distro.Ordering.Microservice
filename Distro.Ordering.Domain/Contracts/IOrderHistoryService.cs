using Distro.Domain.Common;
using Distro.Ordering.Domain.Entities;

namespace Distro.Ordering.Domain.Contracts
{
    public interface IOrderHistoryService : IApplicationService
    {
        public IEnumerable<Order> GetOrderHistory(Guid customerId);

        public IEnumerable<Order> DelayPendingOrdersWithSpecificProduct(string productCode, int days);
    }
}
