using CSU.Application.Services;
using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSU.Application.Interfaces
{
    public interface ISponsorsService
    {
        Task<SponsorsResponse> CreateAsync(CreateSponsorsRequest request, Guid sponsorsId);
        Task<List<SponsorsResponse>?> GetAllAsync();
        Task<SponsorsResponse?> GetByIdAsync(Guid id);
        Task<bool> DeleteByIdAsync(Guid id);
    }
}
