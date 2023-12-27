using CSU.Domain.News;

namespace CSU.Application.Common.Interfaces
{
    public interface INewsRepository
    {
        Task CreateAsync(News news);
        Task<List<News>?> GetAllAsync();
        Task<News?> GetByIdAsync(Guid id);
        Task UpdateAsync(News news);
        Task AddImages(List<Image> images);
        Task AddHashtags(List<Hashtag> hashtags);
        Task DeleteHashtags(List<Hashtag> hashtags);
    }
}
