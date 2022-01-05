

using Distro.Domain.Common;

namespace Distro.Ordering.Domain.ValueObjects
{
    public class OrderNumber : IPrimitiveValueObject<int>
    {
        public static IEnumerable<int> reservedIds;

        private int? _id;
        public int? Id
        {
            get => _id ;
            set
            {
                //TODO: Check that ID is bigger than largest number in DB
                //TODO: Check that ID is not in reserved list

                _id = value;
            }
        }

        public OrderNumber(int? id = null)
        {
            _id = id ;
            if (reservedIds == null)
            {
                reservedIds = new List<int>();
            }
        }

        public override string ToString()
        {
            return Id?.ToString().PadLeft(5, '0') ?? "00000";
        }

        public int GetValue()
        {
            return Id ?? -1;
        }
    }
}
