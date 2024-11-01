using Entities.Dtos.ApartmentDtos;
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
    public class ApartmentController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ApartmentController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        [EnableQuery]
        public IActionResult GetAllApartments()
        {
            return Ok(_serviceManager.ApartmentService.GetAllApartments());
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateApartment([FromBody] CreateApartmentDto createApartmentDto)
        {
            await _serviceManager.ApartmentService.CreateApartmentAsync(createApartmentDto);
            return Ok();
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateApartment([FromBody] UpdateApartmentDto updateApartmentDto)
        {
            await _serviceManager.ApartmentService.UpdateApartmentAsync(updateApartmentDto);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteApartment(int id)
        {
            await _serviceManager.ApartmentService.DeleteApartmentAsync(id);
            return Ok();
        }
    }
}
