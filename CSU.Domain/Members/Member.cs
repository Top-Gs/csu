using CSU.Domain.Users;

namespace CSU.Domain.Members
{
    public class Member
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public byte[] ProfileImage { get; set; } = null!;
        public MemberType Type { get; set; } = null!;
        public string Championship { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public Double Height { get; set; }
        public string Description { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Guid ModifiedBy { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<Award> Awards { get; } = new List<Award>();
        public ICollection<MemberRole> Roles { get; } = new List<MemberRole>();
    }
}
