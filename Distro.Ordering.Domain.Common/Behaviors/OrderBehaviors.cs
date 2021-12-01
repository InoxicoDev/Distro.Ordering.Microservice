﻿
using Distro.Ordering.Domain.Common.Entities;

namespace Distro.Ordering.Domain.Common.Behaviors
{
    public class OrderBehaviors
    {
        public Order Parent { get; set; }

        public OrderBehaviors(Order entity)
        {
            Parent = entity;
        }
    }

    public static class OrderBehaviorsExtensions
    {
        public static void Update(this OrderBehaviors original, Order updatedOrder)
        {
            original.Parent.OrderNumber = updatedOrder.OrderNumber;
            original.Parent.Price = updatedOrder.Price;
        }
    }
}
