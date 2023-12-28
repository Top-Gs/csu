using CSU.Contracts.V1.Responses;

namespace CSU.Application.Interfaces
{
    public interface IHashtagService
    {
        Task<List<HashtagResponse>> GetAllAsync();
    }
}
