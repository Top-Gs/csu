using AutoMapper;

using CSU.Application.Dtos.V1.Requests;
using CSU.Application.Dtos.V1.Responses;
using CSU.Domain.Entities;

namespace CSU.Application.Mapping
{
    public class NewsProfile : Profile
    {
        public NewsProfile()
        {
            CreateMap<CreateNewsRequest, News>()
                .ForMember(dest => dest.Images, opt => opt.Ignore());

            CreateMap<News, NewsResponse>()
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images.Select(w => Convert.ToBase64String(w.ImageData)).ToList()));
        }
    }
}
