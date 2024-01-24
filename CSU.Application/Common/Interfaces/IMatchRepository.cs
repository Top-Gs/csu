using CSU.Domain.Matches;

namespace CSU.Application.Common.Interfaces
{
    public interface IMatchRepository
    {

        Task CreateAsync(Match match);
        Task<List<Match>?> GetAllAsync(int number);
        Task<Match?> GetByIdAsync(Guid id);
        Task DeleteAsync(Match match);
    }
}
