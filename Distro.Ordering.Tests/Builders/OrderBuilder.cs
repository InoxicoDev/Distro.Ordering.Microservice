using Distro.Ordering.Domain.Entities;
using System;

namespace Distro.Ordering.Tests.Builders
{
    public class OrderBuilder : Order
    {

        public OrderBuilder(Guid? id = null)
        {
            this.Id = id ?? Guid.NewGuid();
        }

        public OrderBuilder SampleOrder()
        {
            this.Price = 15.22m;
            this.OrderNumber = "323";

            return this;
        }

        public Order Build()
        {
            return this;
        }
    }
}
