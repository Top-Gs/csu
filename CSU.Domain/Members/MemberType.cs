using Ardalis.SmartEnum;

namespace CSU.Domain.Members
{
    public class MemberType : SmartEnum<MemberType>
    {
        public static readonly MemberType Trainer = new(nameof(Trainer), 0);
        public static readonly MemberType Player = new(nameof(Player), 1);
        public static readonly MemberType Junior = new(nameof(Junior), 2);

        public MemberType(string name, int value) : base(name, value)
        {
        }
    }
}
