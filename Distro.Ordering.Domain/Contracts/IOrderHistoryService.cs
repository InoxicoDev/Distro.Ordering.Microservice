using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Contracts
{
    public interface IOrderHistoryService : IDomainService
    {
        public IEnumerable<Order> GetOrderHistory(Guid customerId);
    }
}
