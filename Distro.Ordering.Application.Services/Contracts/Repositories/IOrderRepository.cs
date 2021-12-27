using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.Application.Services.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }
}
