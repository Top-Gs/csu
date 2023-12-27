using CSU.Application.Common.Interfaces;
using CSU.Domain.News;
using CSU.Infrastructure.Common.Persistence;

namespace CSU.Infrastructure.News.Persistence
{
    public class NewsRepository : INewsRepository
    {
        private readonly CsuDbContext _dataContext;

        public NewsRepository(CsuDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateAsync(Domain.News.News news)
        {
            await _dataContext.News.AddAsync(news);
        }

        public async Task AddImages(List<Image> images)
        {
            await _dataContext.Images.AddRangeAsync(images);
        }

        public async Task AddHashtags(List<Hashtag> hashtags)
        {
            await _dataContext.Hashtags.AddRangeAsync(hashtags);
        }
    }
}
