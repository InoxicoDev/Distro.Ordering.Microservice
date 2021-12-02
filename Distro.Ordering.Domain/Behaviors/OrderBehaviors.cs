using Distro.Ordering.Domain.Entities;

namespace Distro.Ordering.Domain.Behaviors
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
            original.Parent.OrderNumberWrapper = updatedOrder.OrderNumberWrapper;
            original.Parent.Price = updatedOrder.Price;
        }
    }
}
