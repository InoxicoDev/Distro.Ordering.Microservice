
using Distro.Ordering.Domain.Behaviors;
using Distro.Seedworks.Infrastructure.DataAccess;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Common.Entities
{
    public class Order : EntityBase<OrderBehaviors>, IDatabaseEntity
    {
        public Guid Id { get; set; }

        public string? OrderNumber { get; set; }

        public decimal? Price { get; set; }
    }
}
