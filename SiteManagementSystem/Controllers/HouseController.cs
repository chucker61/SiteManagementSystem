using Entities.Dtos.HouseDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Services.Contracts;
using SiteManagementSystem.ActionFilters;

namespace HouseManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HouseController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public HouseController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        [EnableQuery]
        public IActionResult GetAllHouses()
        {
            return Ok(_serviceManager.HouseService.GetAllHouses());
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateHouse([FromBody] CreateHouseDto createHouseDto)
        {
            await _serviceManager.HouseService.CreateHouseAsync(createHouseDto);
            return Ok();
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateHouse([FromBody] UpdateHouseDto updateHouseDto)
        {
            await _serviceManager.HouseService.UpdateHouseAsync(updateHouseDto);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteHouse(int id)
        {
            await _serviceManager.HouseService.DeleteHouseAsync(id);
            return Ok();
        }
    }
}
