using AutoMapper;

using CSU.Application.Common.Interfaces;
using CSU.Application.Interfaces;
using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;
using CSU.Domain.Members;
using CSU.Domain.News;

using Microsoft.AspNetCore.Http;

namespace CSU.Application.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MemberService(IMemberRepository memberRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<MemberResponse> CreateAsync(CreateMemberRequest request, Guid userId)
        {
            var member = _mapper.Map<Member>(request);
            member.UserId = userId;

            member.ProfileImage = await ConvertIFormFileToByteArray(request.ProfileImage);

            await _memberRepository.CreateAsync(member);
            await _unitOfWork.CommitChangesAsync();

            var response = _mapper.Map<MemberResponse>(member);

            return response;
        }

        public async Task<MemberResponse> GetByIdAsync(Guid id)
        {
            var member = await _memberRepository.GetByIdAsync(id);

            var response = _mapper.Map<MemberResponse>(member);

            return response;
        }

        private async Task<byte[]> ConvertIFormFileToByteArray(IFormFile file)
        {
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            return memoryStream.ToArray();
        }
    }
}
