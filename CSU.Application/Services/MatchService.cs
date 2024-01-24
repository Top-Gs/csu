using AutoMapper;

using CSU.Application.Common.Interfaces;
using CSU.Application.Interfaces;
using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;
using CSU.Domain.Match;

using Microsoft.AspNetCore.Http;

namespace CSU.Application.Services
{
    public class MatchService: IMatchService
    {
        private readonly IMatchRepository _matchRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MatchService(IMatchRepository matchsRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _matchRepository = matchsRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<MatchResponse>?> GetAllAsync()
        {
            var match = await _matchRepository.GetAllAsync();

            var matchResponse = _mapper.Map<List<MatchResponse>>(match);

            return matchResponse;
        }

        public async Task<MatchResponse> CreateAsync(CreateMatchRequest request, Guid userId)
        {
            var matches = _mapper.Map<Match>(request);
            matches.UserId = userId;


            matches.EnemyTeamLogo = await ConvertIFormFileToByteArray(request.EnemyTeamLogo);

            await _matchRepository.CreateAsync(matches);
            await _unitOfWork.CommitChangesAsync();

            var response = _mapper.Map<MatchResponse>(matches);

            return response;
        }

        public async Task<bool> DeleteByIdAsync(Guid id)
        {
            var match = await _matchRepository.GetByIdAsync(id);

            if (match == null)
            {
                return false;
            }

            await _matchRepository.DeleteAsync(match);
            await _unitOfWork.CommitChangesAsync();

            return true;
        }

        public async Task<MatchResponse?> GetByIdAsync(Guid id)
        {
            var match = await _matchRepository.GetByIdAsync(id);

            var matchResponse = _mapper.Map<MatchResponse>(match);

            return matchResponse;
        }

        private async Task<byte[]> ConvertIFormFileToByteArray(IFormFile file)
        {
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            return memoryStream.ToArray();
        }
    }
}
