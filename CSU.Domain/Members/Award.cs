namespace CSU.Domain.Members
{
    public class Award
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int Place { get; set; }
        public string Championship { get; set; } = null!;
        public DateTime Date { get; set; }

        public Guid MemberId { get; set; }
        public Member Member { get; set; } = null!;
    }
}
