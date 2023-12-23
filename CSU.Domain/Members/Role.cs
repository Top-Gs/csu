namespace CSU.Domain.Members
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Member> Members { get; } = new();
    }
}
