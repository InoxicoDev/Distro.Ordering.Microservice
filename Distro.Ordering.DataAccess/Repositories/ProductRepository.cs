using Distro.Ordering.Domain.Contracts.Repositories;
using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Ordering.DataAccess.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dataContext) : base(dataContext)
        {
        }

        public Product GetProductByCode(string productCode)
        {
            return _table.Where(t => t.ProductCode == productCode).FirstOrDefault();
        }
    }
}
