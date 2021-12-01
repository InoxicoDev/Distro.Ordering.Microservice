using Distro.Ordering.Domain.Contracts.Services;
using Distro.Ordering.Domain.Entities;

namespace Distro.Ordering.Domain.Services.Services
{
    public class OrderHistoryService : IOrderHistoryService
    {
        public IEnumerable<Order> GetOrderHistoryByCustomer(Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
