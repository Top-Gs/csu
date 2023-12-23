using AutoMapper;

using CSU.Contracts.V1.Requests;
using CSU.Domain.Users;

namespace CSU.Application.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserRegistrationRequest, User>()
                .ForMember(dest => dest.Role, opt =>
                    opt.MapFrom(src => UserRole.User));
        }
    }
}
