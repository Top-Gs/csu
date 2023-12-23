namespace CSU.Domain.News
{
    public class Hashtag
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public List<News> News { get; } = new();
    }
}
