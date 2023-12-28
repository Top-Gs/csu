using AutoMapper;

using CSU.Contracts.V1.Responses;
using CSU.Domain.News;

namespace CSU.Application.Mapping
{
    public class HashtagProfile : Profile
    {
        public HashtagProfile()
        {
            CreateMap<Hashtag, HashtagResponse>();
        }
    }
}
