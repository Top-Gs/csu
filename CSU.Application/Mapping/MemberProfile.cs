using AutoMapper;

using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;
using CSU.Domain.Members;

namespace CSU.Application.Mapping
{
    public class MemberProfile : Profile
    {
        public MemberProfile()
        {
            CreateMap<CreateMemberRequest, Member>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => Domain.Members.MemberType.FromValue((int)src.Type)))
                .ForMember(dest => dest.Position, opt => opt.MapFrom(src => Domain.Members.Position.FromValue((int)src.Position)))
                .ForMember(dest => dest.ProfileImage, opt => opt.Ignore());


            CreateMap<Member, MemberResponse>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.Name))
                .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position.Name))
                .ForMember(dest => dest.ProfileImage, opt => opt.MapFrom(src => Convert.ToBase64String(src.ProfileImage!)));
        }
    }
}
