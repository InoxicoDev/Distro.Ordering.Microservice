using Distro.Domain.Common;
using Distro.Ordering.Domain.Contracts.Repositories;
using Distro.Ordering.Domain.Events;

namespace Distro.Ordering.Application.Services;

public class OrderUpdatedDomainEventHandler: IDomainEventHandler<OrderUpdatedDomainEvent>
{
    public OrderUpdatedDomainEventHandler()
    {
        
    }
    
    public void Handle(OrderUpdatedDomainEvent @event)
    {
        //Perform an operation
    }
}

public class SendOrderDelayedEmailDomainCommandHandler: IDomainCommandHandler<SendOrderDelayedEmailDomainCommand>
{
    private readonly IOrderRepository _orderRepository;

    public SendOrderDelayedEmailDomainCommandHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public void Handle(SendOrderDelayedEmailDomainCommand @event)
    {
        var orders = _orderRepository.FindAll();
        //Perform a command
    }
}

public class GetOrderNumberDomainRequestHandler: IDomainRequestHandler<GetOrderNumberDomainRequest, string>
{
    public GetOrderNumberDomainRequestHandler()
    {
        
    }
    
    public string Handle(GetOrderNumberDomainRequest request)
    {
        return "12345";
    }
}