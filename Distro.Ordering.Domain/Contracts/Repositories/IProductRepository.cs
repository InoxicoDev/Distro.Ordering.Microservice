using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.Domain.Contracts.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public Product GetProductByCode(string productCode);
    }
}
