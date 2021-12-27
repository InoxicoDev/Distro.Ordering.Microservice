using Distro.Ordering.Domain.Contracts.Repositories;
using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.DataAccess.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext dataContext) : base(dataContext)
        {
        }

        public IEnumerable<Order> FindOrdersWithSpecificProduct(Guid productId)
        {
            return _table.Where(t => t.Items.Any(x => x.ProductId == productId));
        }
    }
}
