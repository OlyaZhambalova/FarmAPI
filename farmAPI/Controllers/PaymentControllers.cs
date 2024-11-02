using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _paymentService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _paymentService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Payment payment)
        {
            await _paymentService.Create(payment);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Payment payment)
        {
            await _paymentService.Update(payment);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _paymentService.Delete(id);
            return Ok();
        }
    }
}