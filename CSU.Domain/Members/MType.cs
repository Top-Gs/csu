using Ardalis.SmartEnum;

namespace CSU.Domain.Members
{
    public class MType : SmartEnum<MType>
    {
        public static readonly MType Trainer = new(nameof(Trainer), 0);
        public static readonly MType Player = new(nameof(Player), 1);
        public static readonly MType Junior = new(nameof(Junior), 2);

        public MType(string name, int value) : base(name, value)
        {
        }
    }
}
