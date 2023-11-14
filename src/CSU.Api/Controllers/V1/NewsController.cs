using CSU.Application.Dtos.V1.Requests;
using CSU.Application.Intefaces;

using Microsoft.AspNetCore.Mvc;

namespace CSU.Api.Controllers.V1
{
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpPost(ApiEndpoints.V1.News.Create)]
        public async Task<IActionResult> Create([FromForm] CreateNewsRequest request)
        {
            var news = await _newsService.CreateAsync(request);

            return Ok(news);
        }

        [HttpGet(ApiEndpoints.V1.News.Get)]
        public async Task<IActionResult> Create([FromRoute] Guid id)
        {
            var news = await _newsService.GetByIdAsync(id);

            if (news == null)
            {
                return NotFound();
            }

            return Ok(news);
        }

        [HttpGet(ApiEndpoints.V1.News.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var news = await _newsService.GetAllAsync();

            return Ok(news);
        }

        [HttpPut(ApiEndpoints.V1.News.Update)]
        public async Task<IActionResult> Update([FromRoute] Guid id,
            [FromForm] UpdateNewsRequest request)
        {
            var updatedNews = await _newsService.UpdateAsync(id, request);

            if (updatedNews == null)
            {
                return NotFound();
            }

            return Ok(updatedNews);
        }

        [HttpDelete(ApiEndpoints.V1.News.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deleted = await _newsService.DeleteByIdAsync(id);

            return deleted ? Ok() : NotFound();
        }
    }
}
