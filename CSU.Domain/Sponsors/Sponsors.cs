using CSU.Domain.Users;

namespace CSU.Domain.Sponsors
{
    public  class Sponsors
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Link { get; set; }
        public byte[] Image { get; set; }
        public required DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Guid ModifiedBy { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

    }
}
