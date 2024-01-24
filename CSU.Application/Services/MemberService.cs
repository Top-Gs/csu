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

            if (request.ProfileImage != null)
            {
                member.ProfileImage = await ConvertIFormFileToByteArray(request.ProfileImage);
            }

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

        public async Task<List<MemberResponse>> GetAll(Contracts.V1.Requests.MemberType? type ,Contracts.V1.Requests.Position? position)
        {
            var dbType = type.HasValue
                ? Domain.Members.MemberType.FromValue((int)type)
                : -1;

            var dbPosition = position.HasValue
                ? Domain.Members.Position.FromValue((int)position)
                : -1;

            var members = await _memberRepository.GetAll(dbType, dbPosition);

            var response = _mapper.Map<List<MemberResponse>>(members);

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
