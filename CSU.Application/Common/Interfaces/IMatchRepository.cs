using CSU.Domain.Match;
using CSU.Domain.Sponsors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSU.Application.Common.Interfaces
{
    public interface IMatchRepository
    {

        Task CreateAsync(Match match);
        Task<List<Match>?> GetAllAsync();
        Task<Match?> GetByIdAsync(Guid id);
        Task DeleteAsync(Match match);
    }
}
