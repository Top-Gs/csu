using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

using CSU.Domain.Match;

using AutoMapper;
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
