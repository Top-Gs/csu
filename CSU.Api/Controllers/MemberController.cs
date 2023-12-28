using CSU.Api.Extensions;
using CSU.Application.Interfaces;
using CSU.Contracts.V1.Requests;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CSU.Api.Controllers
{
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;
        private readonly ILogger _logger;

        public MemberController(IMemberService memberService, ILogger<MemberController> logger)
        {
            _memberService = memberService;
            _logger = logger;
        }

        [HttpPost(ApiEndpoints.V1.Member.Create)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,ContentCreator")]
        public async Task<IActionResult> Create([FromForm] CreateMemberRequest request)
        {
            try
            {
                var userId = new Guid(HttpContext.GetUserId());

                var member = await _memberService.CreateAsync(request, userId);

                return Ok(member);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }

        [HttpGet(ApiEndpoints.V1.Member.Get)]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                var member = await _memberService.GetByIdAsync(id);

                return Ok(member);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred: {ErrorMessage}", ex.Message);

                return BadRequest("An error occurred");
            }
        }
    }
}
