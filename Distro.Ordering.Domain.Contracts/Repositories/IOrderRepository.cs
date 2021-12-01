using Distro.Ordering.Domain.Common.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.Domain.Contracts.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }
}
