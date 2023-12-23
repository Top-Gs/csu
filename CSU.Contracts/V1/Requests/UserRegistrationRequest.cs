namespace CSU.Contracts.V1.Requests
{
    public class UserRegistrationRequest
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
