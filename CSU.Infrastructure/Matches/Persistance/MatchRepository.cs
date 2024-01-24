using CSU.Application.Common.Interfaces;
using CSU.Domain.Matches;
using CSU.Infrastructure.Common.Persistence;

using Microsoft.EntityFrameworkCore;

namespace CSU.Infrastructure.Matches.Persistance
{
    public class MatchRepository : IMatchRepository
    {
        private readonly CsuDbContext _dataContext;

        public MatchRepository(CsuDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateAsync(Match match)
        {
            await _dataContext.Match.AddAsync(match);
        }

        public Task DeleteAsync(Match match)
        {
            _dataContext.Match.Remove(match);

            return Task.CompletedTask;
        }

        public async Task<List<Match>?> GetAllAsync(int number)
        {
            IQueryable<Match> query = _dataContext.Match.OrderByDescending(m => m.Date);

            if (number > 0)
            {
                query = query.Take(number);
            }

            var result = await query.ToListAsync();

            return result;
        }

        public async Task<Match?> GetByIdAsync(Guid id)
        {
            var result = await _dataContext.Match
                 .SingleOrDefaultAsync(m => m.Id == id);

            return result;
        }
    }
}
