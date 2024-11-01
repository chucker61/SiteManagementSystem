using Entities.Dtos.PaymentDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using SiteManagementSystem.ActionFilters;

namespace SiteManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public PaymentController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreatePayment(CreatePaymentDto createPaymentDto)
        {
            if (await _serviceManager.PaymentService.CreatePayment(createPaymentDto))
                return Ok("Ödeme Başarılı");
            else
                return BadRequest("Ödeme Başarısız");
        }
    }
}
