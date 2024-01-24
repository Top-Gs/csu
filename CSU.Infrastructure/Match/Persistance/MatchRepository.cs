using CSU.Application.Common.Interfaces;
using CSU.Domain.Sponsors;
using CSU.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSU.Infrastructure.Match.Persistance
{
    public class MatchRepository : IMatchRepository
    {
        private readonly CsuDbContext _dataContext;
        public MatchRepository(CsuDbContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task CreateAsync(Domain.Match.Match match)
        {
            await _dataContext.Match.AddAsync(match);
        }

        public Task DeleteAsync(Domain.Match.Match match)
        {
            _dataContext.Match.Remove(match);

            return Task.CompletedTask;
        }

        public async Task<List<Domain.Match.Match>?> GetAllAsync()
        {
            var result = await _dataContext.Match.ToListAsync();

            return result;
        }

        public async Task<Domain.Match.Match?> GetByIdAsync(Guid id)
        {
            var result = await _dataContext.Match
                 .SingleOrDefaultAsync(m => m.Id == id);

            return result;
        }
    }
}
