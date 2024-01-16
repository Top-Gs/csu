using CSU.Api.Extensions;
using CSU.Application.Common.Interfaces;
using CSU.Application.Interfaces;
using CSU.Application.Services;
using CSU.Contracts.V1.Requests;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Security;
namespace CSU.Api.Controllers

{
    [ApiController]
    public class SponsorsController : ControllerBase
    {
        private readonly ISponsorsService _sponsorsService;
        private readonly ILogger _logger;
        public SponsorsController(ISponsorsService SponsorsService, ILogger<SponsorsController> logger)
        {
            _sponsorsService = SponsorsService;
            _logger = logger;
        }

        [HttpPost(ApiEndpoints.V1.Sponsors.Create)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,ContentCreator")]
        public async Task<IActionResult> Create([FromForm] CreateSponsorsRequest request)
        {
            try
            {

                var userId = new Guid(HttpContext.GetUserId());

                var sponsors = await _sponsorsService.CreateAsync(request, userId);

                return CreatedAtAction(nameof(Get), new { id = sponsors.Id }, sponsors);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }
        [HttpGet(ApiEndpoints.V1.Sponsors.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var news = await _sponsorsService.GetAllAsync();

                return Ok(news);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }
        [HttpGet(ApiEndpoints.V1.Sponsors.Get)]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                var sponsors = await _sponsorsService.GetByIdAsync(id);

                if (sponsors == null)
                {
                    return NotFound();
                }

                return Ok(sponsors);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }

        [HttpDelete(ApiEndpoints.V1.Sponsors.Delete)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,ContentCreator")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            try
            {
                var deleted = await _sponsorsService.DeleteByIdAsync(id);

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
