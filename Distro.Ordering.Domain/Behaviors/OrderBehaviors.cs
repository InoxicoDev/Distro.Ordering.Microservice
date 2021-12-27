using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Behaviors
{
    public static class OrderExtention
    {
        public static OrderBehaviors Behaviors(this Order original)
        {
            return new OrderBehaviors(original);
        }
    }

    public class OrderBehaviors : EntityBehaviorBase<Order>
    {
        public OrderBehaviors(Order domainEntity) : base(domainEntity)
        {
        }

        public void Update(Order updatedOrder)
        {
            DomainEntity.OrderNumber = updatedOrder.OrderNumber;
            DomainEntity.Price = updatedOrder.Price;
        }
        public void Add(Order updatedOrder)
        {
        }
    }
}
