using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;

namespace CSU.Application.Interfaces
{
    public interface IMemberService
    {
        Task<MemberResponse> CreateAsync(CreateMemberRequest request, Guid userId);
        Task<MemberResponse> GetByIdAsync(Guid id);
    }
}
