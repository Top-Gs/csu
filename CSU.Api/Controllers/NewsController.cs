using CSU.Api.Extensions;
using CSU.Application.Interfaces;
using CSU.Contracts.V1.Requests;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CSU.Api.Controllers
{
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;
        private readonly ILogger _logger;

        public NewsController(INewsService newsService, ILogger<NewsController> logger)
        {
            _newsService = newsService;
            _logger = logger;
        }

        [HttpPost(ApiEndpoints.V1.News.Create)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,ContentCreator")]
        public async Task<IActionResult> Create([FromForm] CreateNewsRequest request)
        {
            try
            {
                var userId = new Guid(HttpContext.GetUserId());

                var news = await _newsService.CreateAsync(request, userId);

                return Ok(news);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }

        [HttpGet(ApiEndpoints.V1.News.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var news = await _newsService.GetAllAsync();

                return Ok(news);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }

        [HttpGet(ApiEndpoints.V1.News.Get)]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                var news = await _newsService.GetByIdAsync(id);

                if (news == null)
                {
                    return NotFound();
                }

                return Ok(news);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }
    }
}
