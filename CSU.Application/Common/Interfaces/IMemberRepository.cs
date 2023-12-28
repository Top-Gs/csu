using CSU.Domain.Members;

namespace CSU.Application.Common.Interfaces
{
    public interface IMemberRepository
    {
        Task CreateAsync(Member member);
        Task<Member?> GetByIdAsync(Guid id);
    }
}
