using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;

namespace CSU.Application.Interfaces
{
    public interface INewsService
    {
        Task<NewsResponse> CreateAsync(CreateNewsRequest request, Guid userId);
    }
}
