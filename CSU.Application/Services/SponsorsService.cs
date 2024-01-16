using AutoMapper;
using CSU.Application.Common.Interfaces;
using CSU.Application.Interfaces;
using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;

using CSU.Domain.Sponsors;
using CSU.Domain.Users;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSU.Application.Services
{
    public  class SponsorsService : ISponsorsService
    {
        private readonly ISponsorsRepository _sponsorsRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SponsorsService(ISponsorsRepository sponsorsRepository,IUnitOfWork unitOfWork, IMapper mapper)
        {
            _sponsorsRepository = sponsorsRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<SponsorsResponse> CreateAsync(CreateSponsorsRequest request, Guid userId)
        {
            var sponsors = _mapper.Map<Sponsors>(request);
            sponsors.UserId = userId;


            sponsors.Image = await ConvertIFormFileToByteArray(request.Image);

            await _sponsorsRepository.CreateAsync(sponsors);
            await _unitOfWork.CommitChangesAsync();

            var response = _mapper.Map<SponsorsResponse>(sponsors);


            return response;
        }

        public async Task<SponsorsResponse?> GetByIdAsync(Guid id)
        {
            var sponsors = await _sponsorsRepository.GetByIdAsync(id);

            var sponsorsResponse = _mapper.Map<SponsorsResponse>(sponsors);

            return sponsorsResponse;
        }

        public  async Task<List<SponsorsResponse>?> GetAllAsync()
        {
            var sponsors = await _sponsorsRepository.GetAllAsync();

            var sponsorsResponse = _mapper.Map<List<SponsorsResponse>>(sponsors);

            return sponsorsResponse;
        }

        public async Task<bool> DeleteByIdAsync(Guid id)
        {
            var sponsors = await _sponsorsRepository.GetByIdAsync(id);

            if (sponsors == null)
            {
                return false;
            }

            await _sponsorsRepository.DeleteAsync(sponsors);
            await _unitOfWork.CommitChangesAsync();

            return true;
        }

        private async Task<byte[]> ConvertIFormFileToByteArray(IFormFile file)
        {
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            return memoryStream.ToArray();
        }
    }
}
