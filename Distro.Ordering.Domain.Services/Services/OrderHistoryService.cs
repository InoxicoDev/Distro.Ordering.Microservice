using Distro.Ordering.Domain.Contracts;
using Distro.Ordering.Domain.Entities;

namespace Distro.Ordering.Domain.Services.Services
{
    public class OrderHistoryService : IOrderHistoryService
    {
        public IEnumerable<Order> GetOrderHistory(Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
