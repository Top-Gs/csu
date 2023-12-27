using CSU.Domain.News;

namespace CSU.Application.Common.Interfaces
{
    public interface INewsRepository
    {
        Task CreateAsync(News news);
        Task<List<News>?> GetAllAsync();
        Task AddImages(List<Image> images);
        Task AddHashtags(List<Hashtag> hashtags);
    }
}
