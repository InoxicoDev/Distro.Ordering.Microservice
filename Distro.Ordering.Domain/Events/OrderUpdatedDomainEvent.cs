using Distro.Domain.Common;

namespace Distro.Ordering.Domain.Events;

public class OrderUpdatedDomainEvent: IDomainEvent
{
    public Guid OrderId { get; }

    public OrderUpdatedDomainEvent(Guid orderId)
    {
        OrderId = orderId;
    }
}

public class GetOrderNumberDomainRequest : IDomainRequest
{
}

public class SendOrderDelayedEmailDomainCommand : IDomainCommand
{
    public Guid OrderId { get; }

    public SendOrderDelayedEmailDomainCommand(Guid orderId)
    {
        OrderId = orderId;
    }
}