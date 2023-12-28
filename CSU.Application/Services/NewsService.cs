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

        public async Task<List<NewsResponse>?> GetAllAsync()
        {
            var news = await _newsRepository.GetAllAsync();

            var newsResponse = _mapper.Map<List<NewsResponse>>(news);

            return newsResponse;
        }

        public async Task<NewsResponse?> GetByIdAsync(Guid id)
        {
            var news = await _newsRepository.GetByIdAsync(id);

            var newsResponse = _mapper.Map<NewsResponse>(news);

            return newsResponse;
        }

        public async Task<NewsResponse?> UpdateAsync(Guid newsId, UpdateNewsRequest request, Guid userId)
        {
            var news = await _newsRepository.GetByIdAsync(newsId);

            if (news == null)
            {
                return null;
            }

            news.Title = request.Title;
            news.Description = request.Description;
            news.State = Domain.News.NewsState.FromValue((int)request.State);
            news.ScheduledDate = request.ScheduledDate;
            news.ModifiedBy = userId;

            var imageDataTasks = request.Images.Select(ConvertIFormFileToByteArray);
            var imageDatas = await Task.WhenAll(imageDataTasks);

            var images = imageDatas.Select((imageData, index) => new Image { ImageData = imageData, News = news }).ToList();
            var hashtags = request.Hashtags.Select(h => new Hashtag { Name = h, News = new List<News> { news } }).ToList();

            news.Images = images;

            await _newsRepository.UpdateAsync(news);
            await _newsRepository.DeleteHashtags(news.Hashtags);
            await _newsRepository.AddHashtags(hashtags);
            await _unitOfWork.CommitChangesAsync();

            var newsResponse = _mapper.Map<NewsResponse>(news);

            return newsResponse;
        }

        public async Task<bool> DeleteByIdAsync(Guid id)
        {
            var news = await _newsRepository.GetByIdAsync(id);

            if (news == null || news.State == Domain.News.NewsState.Canceled)
            {
                return false;
            }

            news.State = Domain.News.NewsState.Canceled;

            await _newsRepository.UpdateAsync(news);
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
