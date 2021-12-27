using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.Domain.Contracts.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        public IEnumerable<Order> FindOrdersWithSpecificProduct(Guid productId);
    }
}
