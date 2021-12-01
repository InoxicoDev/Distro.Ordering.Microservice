using Distro.Ordering.Domain.Contracts.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Distro.Ordering.DataAccess.Repositories
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
