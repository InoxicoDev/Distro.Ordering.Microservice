using Distro.Ordering.DataAccess;
using Distro.Ordering.Domain.Contracts;
using Distro.Ordering.Domain.Entities;
using Distro.Ordering.Domain.Services.Services;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace Distro.Ordering.Distribution.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrderHistoryController : CustomControllerBase, IOrderHistoryService
    {
        IOrderHistoryService? _orderHistoryService;

        public OrderHistoryController(ApplicationDbContext dbContext) : base(dbContext)
        {
            _orderHistoryService = new OrderHistoryService(dbContext);
        }

        [HttpGet("GetOrderHistory/{id}")]
        public IEnumerable<Order> GetOrderHistory(Guid customerId)
        {
            IEnumerable<Order> orderHistory;

            try
            {
                using TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled);
                logger.Info($"Test logging Controller");

                orderHistory = _orderHistoryService?.GetOrderHistory(customerId) ?? new List<Order>();

                ts.Complete();
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }

            return orderHistory;
        }
    }
}
