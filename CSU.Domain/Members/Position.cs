using Ardalis.SmartEnum;

namespace CSU.Domain.Members
{
    public class Position : SmartEnum<Position>
    {
        public static readonly Position Antrenor = new(nameof(Antrenor), 0);
        public static readonly Position Centru = new(nameof(Centru), 1);
        public static readonly Position Inter = new(nameof(Inter), 2);
        public static readonly Position Pivot = new(nameof(Pivot), 3);
        public static readonly Position Portar = new(nameof(Portar), 4);

        public Position(string name, int value) : base(name, value)
        {
        }
    }
}
