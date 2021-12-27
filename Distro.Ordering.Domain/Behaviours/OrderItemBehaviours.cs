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
        public static OrderItemBehaviours Behaviors(this OrderItem original)
        {
            return new OrderItemBehaviours(original);
        }
    }

    public class OrderItemBehaviours : EntityBehaviourBase<OrderItem>
    {
        public OrderItemBehaviours(OrderItem domainEntity) : base(domainEntity)
        {
        }

        // TODO: Add Order Item Behaviors Here
    }
}
