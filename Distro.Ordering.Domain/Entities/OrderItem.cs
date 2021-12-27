using Distro.Ordering.Domain.Behaviors;
using Distro.Seedworks.Infrastructure.DataAccess;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Entities
{
    public class OrderItem : EntityBase<OrderItemBehaviors>, IDatabaseEntity
    {
        public Guid Id { get; set; }


    }
}
