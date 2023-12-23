namespace CSU.Domain.Members
{
    public class Award
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int Place { get; set; }
        public bool TeamAward { get; set; }

        public Guid ChampionshipId { get; set; }
        public Championship Championship { get; set; } = null!;
        public List<Member> Members { get; } = new();
    }
}
