using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSU.Application.Interfaces
{
    public interface IMatchService
    {
        Task<MatchResponse> CreateAsync(CreateMatchRequest request, Guid matchId);
        Task<MatchResponse?> GetByIdAsync(Guid id);
        Task<List<MatchResponse>?> GetAllAsync();
        Task<bool> DeleteByIdAsync(Guid id);

    }
}
