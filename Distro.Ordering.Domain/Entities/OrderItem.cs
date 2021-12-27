using Distro.Ordering.Domain.Behaviors;
using Distro.Seedworks.Infrastructure.DataAccess;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Entities
{
    public class OrderItem : EntityBase<OrderItemBehaviours>, IDatabaseEntity
    {
        public Guid Id { get; set; }

        public int Quantity { get; set; }

        public Guid OrderId { get; private set; }

        public virtual Order Order { get; set; }

        public Guid ProductId { get; private set; }

        public virtual Product Product { get; set; }
    }
}
