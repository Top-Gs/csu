using CSU.Contracts.V1.Requests;

namespace CSU.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<bool> RegisterAsync(UserRegistrationRequest request);
        Task<string?> LoginAsync(LoginUserRequest request);
    }
}
