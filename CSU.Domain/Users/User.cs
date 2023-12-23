using CSU.Domain.Members;

namespace CSU.Domain.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public UserRole Role { get; set; } = null!;
        public string Token { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }

        public ICollection<News.News> News { get; } = new List<News.News>();
        public ICollection<Member> Members { get; } = new List<Member>();
    }
}
