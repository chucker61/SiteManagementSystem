using Entities.Dtos.SiteDtos;
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
    [Authorize(Roles = "SiteManager")]
    public class SiteController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public SiteController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        [EnableQuery]
        [Authorize(Roles = "Administrator")]
        public IActionResult GetAllSites()
        {
            return Ok(_serviceManager.SiteService.GetAllSites());
        }

        [HttpGet("{userName}")]
        public IActionResult GetOneSiteOfSiteManager(string userName)
        {
            return Ok(_serviceManager.SiteService.GetOneSiteOfSiteManager(userName));
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateSite([FromBody] CreateSiteDto createSiteDto)
        {
            await _serviceManager.SiteService.CreateSiteAsync(createSiteDto);
            return Ok();
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateSite([FromBody] UpdateSiteDto updateSiteDto)
        {
            await _serviceManager.SiteService.UpdateSiteAsync(updateSiteDto);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteSite(int id)
        {
            await _serviceManager.SiteService.DeleteSiteAsync(id);
            return Ok();
        }

        private string GetCurrentUserName()
        {
            var userName = User.Identity.Name;
            if (userName == null)
            {
                throw new Exception("Username is null");
            }
            return userName;
        }

    }
}
