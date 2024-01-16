using CSU.Domain.News;
using CSU.Domain.Sponsors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSU.Application.Common.Interfaces
{
    public interface ISponsorsRepository
    {
        Task CreateAsync(Sponsors sponsors);
        Task<List<Sponsors>?> GetAllAsync();
        Task<Sponsors?> GetByIdAsync(Guid id);
        Task DeleteAsync(Sponsors sponsors);
    }
}
