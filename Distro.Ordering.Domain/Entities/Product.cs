using Distro.Domain.Common;
using Distro.Ordering.Domain.Behaviours;

namespace Distro.Ordering.Domain.Entities
{
    public class Product : EntityBase<ProductBehaviours>, IDatabaseEntity, IAggregateRoot
    {
        public Guid Id { get; set; }

        public string ProductCode { get; set; }

        public string Name {get; set;}

        public string Supplier { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
