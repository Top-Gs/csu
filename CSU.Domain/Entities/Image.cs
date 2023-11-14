namespace CSU.Domain.Entities
{
    public class Image
    {
        public Guid Id { get; set; }
        public byte[] ImageData { get; set; } = null!;

        public Guid NewsId { get; set; }
        public News News { get; set; } = null!;
    }
}
