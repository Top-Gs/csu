using CSU.Domain.Users;

namespace CSU.Domain.News
{
    public class News
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public NewsState State { get; set; } = null!;
        public DateTime ScheduledDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Guid ModifiedBy { get; set; }

        public ICollection<Image> Images { get; set; } = new List<Image>();
        public List<Hashtag> Hashtags { get; } = new();
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
