using CSU.Domain.Users;

namespace CSU.Domain.Members
{
    public class Member
    {
        public Guid Id { get; set; }
        public MemberType Type { get; set; } = null!;
        public byte[] ProfileImage { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public Double Height { get; set; }
        public string Description { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Guid ModifiedBy { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public List<Award> Awards { get; } = new();
        public List<Role> Roles { get; } = new();
        public List<Championship> Championships { get; } = new();
    }
}
