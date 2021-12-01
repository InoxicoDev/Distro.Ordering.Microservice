
namespace Distro.Seedworks.Infrastructure.Domain
{
    public class EntityBase<T> : IDomainEntity
    {
        public T? Behaviors { get; set; }
    }
}
