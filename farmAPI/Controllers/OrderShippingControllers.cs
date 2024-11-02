using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderShippingController : ControllerBase
    {
        private readonly IOrderShippingService _orderShippingService;

        public OrderShippingController(IOrderShippingService orderShippingService)
        {
            _orderShippingService = orderShippingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _orderShippingService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _orderShippingService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(OrderShipping orderShipping)
        {
            await _orderShippingService.Create(orderShipping);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(OrderShipping orderShipping)
        {
            await _orderShippingService.Update(orderShipping);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _orderShippingService.Delete(id);
            return Ok();
        }
    }
}