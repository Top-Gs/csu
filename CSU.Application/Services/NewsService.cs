using AutoMapper;

using CSU.Application.Common.Interfaces;
using CSU.Application.Interfaces;
using CSU.Contracts.V1.Requests;
using CSU.Contracts.V1.Responses;
using CSU.Domain.News;

using Microsoft.AspNetCore.Http;

namespace CSU.Application.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NewsService(INewsRepository newsRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<NewsResponse> CreateAsync(CreateNewsRequest request, Guid userId)
        {
            var news = _mapper.Map<News>(request);
            news.UserId = userId;

            var imageDataTasks = request.Images.Select(ConvertIFormFileToByteArray);
            var imageDatas = await Task.WhenAll(imageDataTasks);

            var images = imageDatas.Select((imageData, index) => new Image { ImageData = imageData, News = news }).ToList();
            var hashtags = request.Hashtags.Select(h => new Hashtag { Name = h, News = new List<News> { news } }).ToList();

            await _newsRepository.CreateAsync(news);
            await _newsRepository.AddImages(images);
            await _newsRepository.AddHashtags(hashtags);
            await _unitOfWork.CommitChangesAsync();

            var response = _mapper.Map<NewsResponse>(news);
            response.CreatedBy = userId;

            return response;
        }

        private async Task<byte[]> ConvertIFormFileToByteArray(IFormFile file)
        {
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            return memoryStream.ToArray();
        }
    }
}
