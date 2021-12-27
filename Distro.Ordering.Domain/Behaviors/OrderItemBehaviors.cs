using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distro.Ordering.Domain.Behaviors
{
    public static class OrderItemExtention
    {
        public static OrderItemBehaviors Behaviors(this OrderItem original)
        {
            return new OrderItemBehaviors(original);
        }
    }

    public class OrderItemBehaviors : EntityBehaviorBase<OrderItem>
    {
        public OrderItemBehaviors(OrderItem domainEntity) : base(domainEntity)
        {
        }

        // TODO: Add Order Item Behaviors Here
    }
}
