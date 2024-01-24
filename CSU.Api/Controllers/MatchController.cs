using CSU.Api.Extensions;
using CSU.Application.Interfaces;
using CSU.Contracts.V1.Requests;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CSU.Api.Controllers
{
    public class MatchController : ControllerBase
    {
        private readonly IMatchService _matchService;
        private readonly ILogger _logger;

        public MatchController(IMatchService MatchsService, ILogger<MatchController> logger)
        {
            _matchService = MatchsService;
            _logger = logger;
        }

        [HttpPost(ApiEndpoints.V1.Match.Create)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,ContentCreator")]
        public async Task<IActionResult> Create([FromForm] CreateMatchRequest request)
        {
            try
            {
                var userId = new Guid(HttpContext.GetUserId());

                var matchs = await _matchService.CreateAsync(request, userId);

                return CreatedAtAction(nameof(Get), new { id = matchs.Id }, matchs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }

        [HttpGet(ApiEndpoints.V1.Match.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var match = await _matchService.GetAllAsync();

                return Ok(match);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }

        [HttpGet(ApiEndpoints.V1.Match.Get)]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                var matchs = await _matchService.GetByIdAsync(id);

                if (matchs == null)
                {
                    return NotFound();
                }

                return Ok(matchs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }

        [HttpDelete(ApiEndpoints.V1.Match.Delete)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,ContentCreator")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            try
            {
                var deleted = await _matchService.DeleteByIdAsync(id);

                return deleted ? NoContent() : NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }
    }
}
