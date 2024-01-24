using AutoMapper;

using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;
using CSU.Domain.Matches;

namespace CSU.Application.Mapping
{
    public class MatchProfile : Profile
    {
        public MatchProfile() {
            CreateMap<CreateMatchRequest, Match>()
                    .ForMember(dest => dest.EnemyTeamLogo, opt => opt.Ignore());
            CreateMap<Match, MatchResponse>()
                    .ForMember(dest => dest.EnemyTeamLogo, opt => opt.MapFrom(src => Convert.ToBase64String(src.EnemyTeamLogo)));
        }
        
    }
}
