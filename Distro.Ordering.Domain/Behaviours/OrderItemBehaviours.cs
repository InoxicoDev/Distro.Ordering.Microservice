using Distro.Domain.Common;
using Distro.Ordering.Domain.Entities;

namespace Distro.Ordering.Domain.Behaviours
{
    public static class OrderItemExtention
    {
        public static OrderItemBehaviours Behaviours(this OrderItem original)
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
