namespace CSU.Domain.Members
{
    public class MemberRole
    {
        public Guid MemberId { get; set; }
        public Guid RoleId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
