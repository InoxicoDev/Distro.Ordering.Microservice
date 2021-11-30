using Distro.Ordering.Domain.Contracts.Entities;
using Distro.Ordering.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distro.Ordering.Domain.Services.Services
{
    public class OrderHistoryService : IOrderHistoryService
    {
        public IEnumerable<Order> GetOrderHistoryByCustomer(Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
