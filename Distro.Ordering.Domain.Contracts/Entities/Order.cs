using Distro.Seedworks.DataAccess.Respository.Contracts;
using Distro.Seedworks.Domain.Entities;

namespace Distro.Ordering.Domain.Contracts.Entities
{
    public class Order : IDatabaseEntity, IDomainEntity
    {
        public Guid Id { get; set; }
    }
}
