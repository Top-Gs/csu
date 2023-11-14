using CSU.Application.Dtos.V1.Requests;

namespace CSU.Application.Dtos.V1.Responses
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
        public required List<string> Images { get; set; }
    }
}
