using AutoMapper;

using CSU.Application.Comman.Interfaces;
using CSU.Application.Dtos.V1.Requests;
using CSU.Application.Dtos.V1.Responses;
using CSU.Application.Intefaces;
using CSU.Domain.Entities;

using Microsoft.AspNetCore.Http;

namespace CSU.Application.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        private readonly IMapper _mapper;

        public NewsService(INewsRepository newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }

        public async Task<NewsResponse> CreateAsync(CreateNewsRequest request)
        {
            var newNews = _mapper.Map<News>(request);

            var imageDataTasks = request.Images.Select(image => ConvertIFormFileToByteArray(image));
            var imageDatas = await Task.WhenAll(imageDataTasks);

            var images = imageDatas.Select((imageData, index) => new CSU.Domain.Entities.Image { ImageData = imageData, News = newNews }).ToList();
            newNews.Images = images;

            await _newsRepository.CreateAsync(newNews);

            var newsResponse = _mapper.Map<NewsResponse>(newNews);

            return newsResponse;
        }

        public async Task<NewsResponse?> GetByIdAsync(Guid id)
        {
            var news = await _newsRepository.GetByIdAsync(id);

            var newsResponse = _mapper.Map<NewsResponse>(news);

            return newsResponse;
        }

        public async Task<List<NewsResponse>?> GetAllAsync()
        {
            var news = await _newsRepository.GetAllAsync();

            var newsResponse = _mapper.Map<List<NewsResponse>>(news);

            return newsResponse;
        }

        public async Task<NewsResponse?> UpdateAsync(Guid id, UpdateNewsRequest request)
        {
            var news = await _newsRepository.GetByIdAsync(id);

            news.Title = request.Title;
            news.Description = request.Description;
            news.State = (CSU.Domain.Enums.NewsState)request.State;
            news.ScheduledDate = request.ScheduledDate;
            news.ModifiedDate = DateTime.Now;
            news.ModifiedBy = Guid.NewGuid();

            var imageDataTasks = request.Images.Select(image => ConvertIFormFileToByteArray(image));
            var imageDatas = await Task.WhenAll(imageDataTasks);

            var images = imageDatas.Select((imageData, index) => new CSU.Domain.Entities.Image { ImageData = imageData, News = news }).ToList();

            news.Images = images;

            await _newsRepository.UpdateAsync(news);

            var newsResponse = _mapper.Map<NewsResponse>(news);

            return newsResponse;
        }

        public async Task<bool> DeleteByIdAsync(Guid id)
        {
            var news = await _newsRepository.GetByIdAsync(id);

            if (news == null)
            {
                return false;
            }

            var deleted = await _newsRepository.DeleteByIdAsync(news);

            return deleted;
        }

        private async Task<byte[]> ConvertIFormFileToByteArray(IFormFile file)
        {
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            return memoryStream.ToArray();
        }
    }
}
