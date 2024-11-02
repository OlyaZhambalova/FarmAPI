using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryService _deliveryService;

        public DeliveryController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _deliveryService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _deliveryService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Delivery delivery)
        {
            await _deliveryService.Create(delivery);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Delivery delivery)
        {
            await _deliveryService.Update(delivery);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _deliveryService.Delete(id);
            return Ok();
        }
    }
}