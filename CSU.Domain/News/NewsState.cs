using Ardalis.SmartEnum;

namespace CSU.Domain.News
{
    public class NewsState : SmartEnum<NewsState>
    {
        public static readonly NewsState Active = new(nameof(Active), 0);
        public static readonly NewsState Draft = new(nameof(Draft), 1);
        public static readonly NewsState Canceled = new(nameof(Canceled), 2);

        public NewsState(string name, int value) : base(name, value)
        {
        }
    }
}
