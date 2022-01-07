using Distro.Domain.Common;
using Distro.Ordering.Domain.Entities;
using Distro.Ordering.Domain.Events;

namespace Distro.Ordering.Domain.Behaviours
{
    public static class OrderExtention
    {
        public static OrderBehaviours Behaviours(this Order original)
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
            
            //var orderNumber = DomainEventPublisher.Instance.Request<GetOrderNumberDomainRequest, string>(new GetOrderNumberDomainRequest());   
            
            DomainEventPublisher.Instance.Send(new SendOrderDelayedEmailDomainCommand(DomainEntity.Id));
            
            //DomainEventPublisher.Instance.Publish(new OrderUpdatedDomainEvent(DomainEntity.Id));
        }
        public void Add(Order updatedOrder)
        {
        }

        public void DelayDelivery(int days)
        {
            if (DomainEntity.IsCompleted) throw new InvalidOperationException("Cannot delay an order that is already completed");

            DomainEntity.DueDate = DomainEntity.DueDate.AddDays(days);
            
            DomainEventPublisher.Instance.Send(new SendOrderDelayedEmailDomainCommand(DomainEntity.Id));

            // Raise delay event
        }
    }
}
