using Microsoft.AspNetCore.Http;

namespace CSU.Application.Dtos.V1.Requests
{
    public class CreateNewsRequest
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required NewsState State { get; set; }
        public DateTime ScheduledDate { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required Guid CreatedBy { get; set; }
        public List<IFormFile> Images { get; set; } = null!;
    }
}
