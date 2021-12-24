using Distro.Ordering.Domain.Entities;
using System;
using Distro.Ordering.Domain.Behaviors;

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
            this.Behaviors().Parent.Price = 99999;
            Price = 33.4m;

            return this;
        }

        public Order Build()
        {
            return this;
        }
    }
}
