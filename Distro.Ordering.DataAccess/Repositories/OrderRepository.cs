using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.DataAccess.Repositories
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(ApplicationDbContext dataContext) : base(dataContext)
        {
        }
    }
}
