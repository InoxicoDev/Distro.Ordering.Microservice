using Distro.Domain.Common;
using Distro.Ordering.Domain.Contracts.Repositories;
using Distro.Ordering.Domain.Events;

namespace Distro.Ordering.Application.Services;

public class OrderUpdatedDomainEventHandler: IDomainEventHandler<OrderUpdatedDomainEvent>
{
    private readonly IOrderRepository _orderRepository;

    public OrderUpdatedDomainEventHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public void Handle(OrderUpdatedDomainEvent @event)
    {
        var a = _orderRepository.FindAll();
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