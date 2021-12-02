
using Distro.Ordering.Domain.Behaviors;
using Distro.Ordering.Domain.ValueObjects;
using Distro.Seedworks.Infrastructure.DataAccess;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Entities
{
    public class Order : EntityBase<OrderBehaviors>, IDatabaseEntity
    {
        public Guid Id { get; set; }

        public int? OrderNumber
        {
            get => OrderNumberWrapper?.GetValue();
        }

        //TODO: Ensure this is populated from oder number field at load
        public OrderNumber? OrderNumberWrapper { get; set; }

        public decimal? Price { get; set; }
    }
}
