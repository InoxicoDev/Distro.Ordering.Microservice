using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.Domain.Services.Contracts.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }
}
