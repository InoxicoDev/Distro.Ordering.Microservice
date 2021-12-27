using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Behaviors
{
    public static class OrderExtention
    {
        public static OrderBehaviours Behaviors(this Order original)
        {
            return new OrderBehaviours(original);
        }
    }

    public class OrderBehaviours : EntityBehaviourBase<Order>
    {
        public OrderBehaviours(Order domainEntity) : base(domainEntity)
        {
        }

        public void Update(Order updatedOrder)
        {
            DomainEntity.OrderNumber = updatedOrder.OrderNumber;
            DomainEntity.Price = updatedOrder.Price;

            // Raise update event
        }
        public void Add(Order updatedOrder)
        {
        }

        public void DelayDelivery(int days)
        {
            if (DomainEntity.IsCompleted) throw new InvalidOperationException("Cannot delay an order that is already completed");

            DomainEntity.DueDate = DomainEntity.DueDate.AddDays(days);

            // Raise delay event
        }
    }
}
