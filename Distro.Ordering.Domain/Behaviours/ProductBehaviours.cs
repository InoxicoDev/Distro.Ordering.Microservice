using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Behaviours
{
    public static class StockExtention
    {
        public static ProductBehaviours Behaviours(this Product original)
        {
            return new ProductBehaviours(original);
        }
    }

    public class ProductBehaviours : EntityBehaviourBase<Product>
    {
        public ProductBehaviours(Product domainEntity) : base(domainEntity)
        {
        }

        // TODO: Add Order Item Behaviors Here
    }
}
