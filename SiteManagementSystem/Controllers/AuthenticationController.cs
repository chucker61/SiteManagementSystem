using Entities.Dtos.AuthenticationDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using SiteManagementSystem.ActionFilters;

namespace SiteManagementSystem.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AuthenticationController(IServiceManager service)
        {
            _service = service;
        }
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] UserDtoForRegistration userDtoForRegistration)
        {
            var result = await _service.AuthenticationService.RegisterUser(userDtoForRegistration);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }
        [HttpPost("login")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Authenticate([FromBody] UserDtoForAuthentication user)
        {
            if (!await _service.AuthenticationService.ValidateUser(user))
                return Unauthorized(); // 401

            var tokenDto = await _service
                .AuthenticationService
                .CreateToken(populateExp: true);

            return Ok(tokenDto);
        }
        [HttpPost("refresh")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        {
            var tokenDtotoReturn = await _service.AuthenticationService.RefreshToken(tokenDto);

            return Ok(tokenDtotoReturn);
        }
    }
}
