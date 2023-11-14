using CSU.Domain.Enums;

namespace CSU.Domain.Entities
{
    public class News
    {
        public required Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required NewsState State { get; set; }
        public DateTime ScheduledDate { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required Guid CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ModifiedBy { get; set; }

        public ICollection<Image> Images { get; set; } = null!;
    }
}
