using CSU.Domain.News;

namespace CSU.Application.Common.Interfaces
{
    public interface IHashtagRepository
    {
        Task<List<Hashtag>> GetAllAsync();
    }
}
