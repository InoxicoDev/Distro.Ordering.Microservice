using Distro.Ordering.Domain.Contracts.Entities;
using Distro.Seedworks.Domain.Services;

namespace Distro.Ordering.Domain.Contracts.Services
{
    public interface IOrderHistoryService : IDomainService
    {
        public IEnumerable<Order> GetOrderHistoryByCustomer(Guid customerId);
    }
}
