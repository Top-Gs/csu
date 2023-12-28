using CSU.Application.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace CSU.Api.Controllers
{
    [ApiController]
    public class HashtagsController : ControllerBase
    {
        private readonly IHashtagService _hashtagService;
        private readonly ILogger _logger;

        public HashtagsController(IHashtagService hashtagService, ILogger<HashtagsController> logger)
        {
            _hashtagService = hashtagService;
            _logger = logger;
        }

        [HttpGet(ApiEndpoints.V1.Hashtags.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var hashtags = await _hashtagService.GetAllAsync();

                return Ok(hashtags);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }
    }
}
