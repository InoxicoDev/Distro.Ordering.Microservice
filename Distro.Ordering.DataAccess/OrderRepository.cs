using Distro.Ordering.Domain.Contracts.Entities;
using Distro.Seedworks.DataAccess.Respository;
using Microsoft.EntityFrameworkCore;

namespace Distro.Ordering.DataAccess
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
