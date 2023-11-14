using CSU.Domain.Entities;

namespace CSU.Application.Comman.Interfaces
{
    public interface INewsRepository
    {
        Task<bool> CreateAsync(News news);
        Task<News?> GetByIdAsync(Guid id);
        Task<List<News>?> GetAllAsync();
        Task<bool> UpdateAsync(News news);
        Task<bool> DeleteByIdAsync(News news);
    }
}
