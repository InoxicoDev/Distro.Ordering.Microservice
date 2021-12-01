﻿using Distro.Ordering.Domain.Common.Entities;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Contracts.Services
{
    public interface IOrderHistoryService : IDomainService
    {
        public IEnumerable<Order> GetOrderHistoryByCustomer(Guid customerId);
    }
}
