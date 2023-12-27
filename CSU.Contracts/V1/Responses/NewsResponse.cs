using CSU.Contracts.V1.Requests;

namespace CSU.Contracts.V1.Responses
{
    public class NewsResponse
    {
        public required Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required NewsState State { get; set; }
        public DateTime ScheduledDate { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required Guid CreatedBy { get; set; }
        public List<string> Images { get; set; } = new();
        public List<string> Hashtags { get; set; } = new();
    }
}
