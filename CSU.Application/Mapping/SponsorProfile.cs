using AutoMapper;

using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;
using CSU.Domain.Sponsors;

namespace CSU.Application.Mapping
{
    public class SponsorProfile : Profile
    {
        public SponsorProfile()
        {
            CreateMap<CreateSponsorsRequest, Sponsors>()
                .ForMember(dest => dest.Image, opt => opt.Ignore());
            CreateMap<Sponsors, SponsorsResponse>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => Convert.ToBase64String(src.Image)));
        }
    }
}
