
using Distro.Ordering.Domain.Behaviors;
using Distro.Seedworks.Infrastructure.DataAccess;
using Distro.Seedworks.Infrastructure.Domain;

namespace Distro.Ordering.Domain.Entities
{
    public class Order : EntityBase<OrderBehaviours>, IDatabaseEntity, IAggregateRoot
    {
        public Guid Id { get; set; }

        // Investigate a value object wrapper for Order Number
        public string OrderNumber { get; set; }

        public decimal? Price { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        public virtual ICollection<OrderItem> Items { get; set; }
    }
}
