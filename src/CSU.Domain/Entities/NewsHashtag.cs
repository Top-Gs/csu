namespace CSU.Domain.Entities
{
    public class NewsHashtag
    {
        public Guid NewsId { get; set; }
        public News News { get; set; } = null!;
        public Guid HashtagId { get; set; }
        public Hashtag Hashtag { get; set; } = null!;
    }
}
