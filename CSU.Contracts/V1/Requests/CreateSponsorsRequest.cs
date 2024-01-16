using Microsoft.AspNetCore.Http;

namespace CSU.Contracts.V1.Requests
{
    public class CreateSponsorsRequest
    {
        public string Name { get; set; } = null;
        public DateTime CreatedAt { get; set; }
        public string Link { get; set; } = null;
        public IFormFile Image { get; set; }
    }
}
