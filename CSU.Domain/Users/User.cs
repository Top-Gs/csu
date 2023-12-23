namespace CSU.Domain.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public UserRole Role { get; set; } = null!;

        public ICollection<News.News> News { get; } = new List<News.News>();
    }
}
