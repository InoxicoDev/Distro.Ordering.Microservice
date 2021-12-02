using Distro.Ordering.DataAccess;
using Distro.Ordering.Domain.Contracts;
using Distro.Ordering.Domain.Entities;
using Distro.Seedworks.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace Distro.Ordering.Distribution.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrderController : CustomControllerBase, IOrderService
    {
        IOrderService? _orderService;

        public OrderController(ApplicationDbContext dbContext, IOrderService? service = null) : base(dbContext)
        {
            _orderService = service;
        }

        public ApplicationDbContext context { get; set; }
        public LogWriter logger { get; set; }

        [HttpGet("GetOrderById/{id}")]
        public Order? GetOrderById(Guid Id)
        {
            Order? order = null;

            try
            {
                using TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled);
                logger.Info($"Test logging Controller");

                order = _orderService?.GetOrderById(Id);

                ts.Complete();
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }

            return order;
        }

        [HttpPost("AddOrder")]
        public Order AddOrder([FromBody] Order order)
        {
            Order? addedOrder = null;

            try
            {
                using TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled);
                logger.Info($"Test logging Controller");

                addedOrder = _orderService.AddOrder(order);

                ts.Complete();
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }

            return addedOrder;
        }

        [HttpPut("UpdateOrder")]
        public Order UpdateOrder([FromBody] Order order)
        {
            Order? updatedOrder = null;

            try
            {
                using TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled);
                logger.Info($"Test logging Controller");

                updatedOrder = _orderService.UpdateOrder(order);

                ts.Complete();
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }

            return updatedOrder;
        }
    }
}
