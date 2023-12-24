using CSU.Application.Interfaces;
using CSU.Contracts.V1.Requests;

using Microsoft.AspNetCore.Mvc;

namespace CSU.Api.Controllers
{
    [ApiController]
    public class IdentityController: ControllerBase
    {
        private readonly IIdentityService _identityService;
        private readonly ILogger _logger;

        public IdentityController(IIdentityService identityService, ILogger<IdentityController> logger)
        {
            _identityService = identityService;
            _logger = logger;
        }

        [HttpPost(ApiEndpoints.V1.Identity.Register)]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest request)
        {
            try
            {
                var registerResponse = await _identityService.RegisterAsync(request);

                if (!registerResponse)
                {
                    return BadRequest("This email is already used");
                }

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }

        [HttpPost(ApiEndpoints.V1.Identity.Login)]
        public async Task<IActionResult> LoginAsync([FromBody] LoginUserRequest request)
        {
            var loginResponse = await _identityService.LoginAsync(request);

            if (loginResponse is null)
            {
                return BadRequest("Email or Password incorrect");
            }

            return Ok(loginResponse);
        }
    }
}
