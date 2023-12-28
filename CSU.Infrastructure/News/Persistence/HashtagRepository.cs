using CSU.Application.Common.Interfaces;
using CSU.Domain.News;
using CSU.Infrastructure.Common.Persistence;

using Microsoft.EntityFrameworkCore;

namespace CSU.Infrastructure.News.Persistence
{
    public class HashtagRepository : IHashtagRepository
    {
        private readonly CsuDbContext _dataContext;

        public HashtagRepository(CsuDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Hashtag>> GetAllAsync()
        {
            return await _dataContext.Hashtags.ToListAsync();
        }
    }
}
