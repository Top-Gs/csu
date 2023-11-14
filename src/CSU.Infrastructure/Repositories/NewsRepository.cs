using CSU.Application.Comman.Interfaces;
using CSU.Domain.Entities;
using CSU.Infrastructure.Comman.Persistence;

using Microsoft.EntityFrameworkCore;

namespace CSU.Infrastructure.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private readonly DataContext _dataContext;

        public NewsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> CreateAsync(News news)
        {
            await _dataContext.News.AddAsync(news);
            var created = await _dataContext.SaveChangesAsync();

            return created > 0;
        }

        public async Task<News?> GetByIdAsync(Guid id)
        {
            var result = await _dataContext.News
                .Include(news => news.Images)
                .SingleOrDefaultAsync(item => item.Id == id);

            return result;
        }

        public async Task<List<News>?> GetAllAsync()
        {
            var result = await _dataContext.News
                .Include(news => news.Images)
                .ToListAsync();

            return result;
        }

        public async Task<bool> UpdateAsync(News news)
        {
            _dataContext.News.Update(news);
            var updated = await _dataContext.SaveChangesAsync();

            return updated > 0;
        }

        public async Task<bool> DeleteByIdAsync(News news)
        {
            _dataContext.News.Remove(news);

            var images = _dataContext.Images.Where(image => image.NewsId == news.Id);
            foreach (var image in images)
            {
                _dataContext.Images.Remove(image);
            }
            var deleted = await _dataContext.SaveChangesAsync();

            return deleted > 0;
        }
    }
}
