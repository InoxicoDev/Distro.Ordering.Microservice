using Distro.Ordering.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Distro.Ordering.Tests.Builders
{
    public class OrderBuilder : Order
    {

        public OrderBuilder(Guid? id = null)
        {
            this.Id = id ?? Guid.NewGuid();
            this.Items = new List<OrderItem>();
        }

        public OrderBuilder SampleOrder()
        {
            this.Price = 15.22m;
            this.OrderNumber = "323";
            this.DueDate = DateTime.Now.AddDays(7);
            this.IsCompleted = false;

            return this;
        }

        public OrderBuilder AddOrderItem(Product product, int quantity)
        {
            this.Items.Add(new OrderItem
            {
                Product = product,
                Quantity = quantity
            });

            return this;
        }

        public Order Build()
        {
            return this;
        }
    }
}
