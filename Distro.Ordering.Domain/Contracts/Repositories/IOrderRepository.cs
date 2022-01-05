using Distro.Domain.Common;
using Distro.Ordering.Domain.Entities;

namespace Distro.Ordering.Domain.Contracts.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        public IEnumerable<Order> FindOrdersWithSpecificProduct(Guid productId);
    }
}
