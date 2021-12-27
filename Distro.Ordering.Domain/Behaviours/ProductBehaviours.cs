using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distro.Ordering.Domain.Behaviours
{
    public static class StockExtention
    {
        public static ProductBehaviours Behaviors(this Product original)
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
