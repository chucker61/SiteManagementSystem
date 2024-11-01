using Entities.Dtos.MembeshipDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Services.Contracts;
using SiteManagementSystem.ActionFilters;

namespace SiteManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class MembershipController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public MembershipController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        [EnableQuery]
        public IActionResult GetAllMemberships()
        {
            return Ok(_serviceManager.MembershipService.GetAllMemberships());
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateMembership([FromBody] CreateMembershipDto createMembershipDto)
        {
            await _serviceManager.MembershipService.CreateMembershipAsync(createMembershipDto);
            return Ok();
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateMembership([FromBody] UpdateMembershipDto updateMembershipDto)
        {
            await _serviceManager.MembershipService.UpdateMembershipAsync(updateMembershipDto);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteMembership(int id)
        {
            await _serviceManager.MembershipService.DeleteMembershipAsync(id);
            return Ok();
        }
    }
}
