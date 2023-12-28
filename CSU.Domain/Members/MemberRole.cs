namespace CSU.Domain.Members
{
    public class MemberRole
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }

        public Guid MemberId { get; set; }
        public Member Member { get; set; } = null!;
    }
}
