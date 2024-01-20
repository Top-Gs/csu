using CSU.Domain.Users;

namespace CSU.Domain.Match
{
    public class Match
    {
        public required Guid Id { get; set; }
        public required DateTime Date { get; set; }
        public required string EnemyTeamName { get; set; }
        public byte[] EnemyTeamLogo { get; set; }
        public required string Location { get; set; }
        public required string Arena { get; set; }
        public required string LiveLink { get; set; }
        public required string Score { get; set; }
        public required DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Guid ModifiedBy { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    }
}