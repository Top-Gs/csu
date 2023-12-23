namespace CSU.Domain.Members
{
    public class Championship
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Member> Members { get; } = new();
        public ICollection<Award> Awards { get; } = new List<Award>();
    }
}
