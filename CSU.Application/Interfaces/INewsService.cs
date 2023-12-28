using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;

namespace CSU.Application.Interfaces
{
    public interface INewsService
    {
        Task<NewsResponse> CreateAsync(CreateNewsRequest request, Guid userId);
        Task<List<NewsResponse>?> GetAllAsync();
        Task<NewsResponse?> GetByIdAsync(Guid id);
        Task<NewsResponse?> UpdateAsync(Guid newsId, UpdateNewsRequest request, Guid userId);
        Task<bool> DeleteByIdAsync(Guid id);
    }
}
