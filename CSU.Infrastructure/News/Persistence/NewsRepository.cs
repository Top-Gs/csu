using CSU.Application.Common.Interfaces;
using CSU.Domain.News;
using CSU.Infrastructure.Common.Persistence;

using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Domain.News.News>?> GetAllAsync()
        {
            var result = await _dataContext.News
                .Include(n => n.Images)
                .Include(n => n.Hashtags)
                .ToListAsync();

            return result;
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
