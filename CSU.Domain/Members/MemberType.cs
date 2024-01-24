using Ardalis.SmartEnum;

namespace CSU.Domain.Members
{
    public class MemberType : SmartEnum<MemberType>
    {
        public static readonly MemberType MainTeam = new(nameof(MainTeam), 0);
        public static readonly MemberType Junior = new(nameof(Junior), 1);

        public MemberType(string name, int value) : base(name, value)
        {
        }
    }
}
