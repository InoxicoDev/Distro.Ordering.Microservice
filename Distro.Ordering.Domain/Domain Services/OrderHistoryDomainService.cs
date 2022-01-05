using Distro.Domain.Common;
using Distro.Ordering.Domain.Contracts.Repositories;
using Distro.Ordering.Domain.Entities;
using Distro.Ordering.Domain.Behaviours;

namespace Distro.Ordering.Domain.Domain_Services
{
    public class OrderHistoryDomainService : IDomainService
    {
        public IOrderRepository OrderRepository { get; set; }

        public IProductRepository ProductRepository { get; set; }

        public OrderHistoryDomainService(IOrderRepository orderRepo, IProductRepository productRepo)
        {
            OrderRepository = orderRepo;
            ProductRepository = productRepo;
        }

        public IEnumerable<Order> DelayPendingOrdersWithSpecificProduct(string productCode, int days)
        {
            var orderItem = ProductRepository.GetProductByCode(productCode);

            var orders = OrderRepository.FindOrdersWithSpecificProduct(orderItem.Id);

            var response = orders.Where(o => !o.IsCompleted); // Need to colapse this into a specification

            foreach(var order in orders)
            {
                order.Behaviours().DelayDelivery(days);
            }

            return response;
        }

    }
}
