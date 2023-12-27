using Ardalis.SmartEnum;

using AutoMapper;

using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;
using CSU.Domain.News;

namespace CSU.Application.Mapping
{
    public class NewsProfile : Profile
    {
        public NewsProfile()
        {
            CreateMap<CreateNewsRequest, News>()
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => Domain.News.NewsState.FromValue((int)src.State)))
                .ForMember(dest => dest.Images, opt => opt.Ignore())
                .ForMember(dest => dest.Hashtags, opt => opt.Ignore());

            CreateMap<News, NewsResponse>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.State.Name))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images.Select(w => Convert.ToBase64String(w.ImageData)).ToList()))
                .ForMember(dest => dest.Hashtags, opt => opt.MapFrom(src => src.Hashtags.Select(w => w.Name)));
        }
    }
}
