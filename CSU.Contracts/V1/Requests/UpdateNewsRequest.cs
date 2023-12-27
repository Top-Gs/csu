using Microsoft.AspNetCore.Http;

namespace CSU.Contracts.V1.Requests
{
    public class UpdateNewsRequest
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public NewsState State { get; set; }
        public DateTime ScheduledDate { get; set; }
        public List<IFormFile> Images { get; set; } = new List<IFormFile>();
        public List<string> Hashtags { get; set; } = new List<string>();
    }
}
