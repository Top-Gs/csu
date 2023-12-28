using AutoMapper;

using CSU.Application.Common.Interfaces;
using CSU.Application.Interfaces;
using CSU.Contracts.V1.Responses;

namespace CSU.Application.Services
{
    public class HashtagService : IHashtagService
    {
        private readonly IHashtagRepository _hashtagRepository;
        private readonly IMapper _mapper;

        public HashtagService(IHashtagRepository hashtagRepository, IMapper mapper)
        {
            _hashtagRepository = hashtagRepository;
            _mapper = mapper;
        }

        public async Task<List<HashtagResponse>> GetAllAsync()
        {
            var hashtags = await _hashtagRepository.GetAllAsync();

            var response = _mapper.Map<List<HashtagResponse>>(hashtags);

            return response;
        }
    }
}
