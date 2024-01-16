using CSU.Application.Common.Interfaces;
using CSU.Infrastructure.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSU.Application.Common.Interfaces;
using CSU.Domain.Sponsors;
using Microsoft.EntityFrameworkCore;

namespace CSU.Infrastructure.Sponsors.Persistence
{
    public class SponsorsRepository : ISponsorsRepository
    {

        private readonly CsuDbContext _dataContext;

        public SponsorsRepository(CsuDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateAsync(Domain.Sponsors.Sponsors sponsors)
        {
            await _dataContext.Sponsors.AddAsync(sponsors);
        }

        public async Task<List<Domain.Sponsors.Sponsors>?> GetAllAsync()
        {
            var result = await _dataContext.Sponsors.ToListAsync();

            return result;
        }

        public async Task<Domain.Sponsors.Sponsors?> GetByIdAsync(Guid id)
        {
            var result = await _dataContext.Sponsors
                .SingleOrDefaultAsync(m => m.Id == id);

            return result;
        }

        public Task DeleteAsync(Domain.Sponsors.Sponsors sponsors)
        {
            _dataContext.Sponsors.Remove(sponsors);

            return Task.CompletedTask;
        }
    }
}
