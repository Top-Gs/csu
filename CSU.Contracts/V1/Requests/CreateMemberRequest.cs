using Microsoft.AspNetCore.Http;

namespace CSU.Contracts.V1.Requests
{
    public class CreateMemberRequest
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public MemberType Type { get; set; }
        public IFormFile ProfileImage { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
