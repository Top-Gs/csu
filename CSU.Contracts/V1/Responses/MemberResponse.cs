using CSU.Contracts.V1.Requests;

namespace CSU.Contracts.V1.Responses
{
    public class MemberResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Description { get; set; } = string.Empty;
        public MemberType Type { get; set; }
        public string ProfileImage { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; } 
    }
}
