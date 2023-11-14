using CSU.Application.Dtos.V1.Requests;
using CSU.Application.Dtos.V1.Responses;

namespace CSU.Application.Intefaces
{
    public interface INewsService
    {
        Task<NewsResponse> CreateAsync(CreateNewsRequest request);
        Task<NewsResponse?> GetByIdAsync(Guid id);
        Task<List<NewsResponse>?> GetAllAsync();
        Task<NewsResponse?> UpdateAsync(Guid id, UpdateNewsRequest request);
        Task<bool> DeleteByIdAsync(Guid id);
    }
}
