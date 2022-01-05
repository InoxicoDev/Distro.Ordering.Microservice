using Distro.Domain.Common;
using Distro.Ordering.Domain.Entities;

namespace Distro.Ordering.Domain.Contracts.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public Product GetProductByCode(string productCode);
    }
}
