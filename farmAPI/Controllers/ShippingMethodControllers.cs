using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingMethodController : ControllerBase
    {
        private readonly IShippingMethodSerivce _shippingMethodService;

        public ShippingMethodController(IShippingMethodSerivce shippingMethodService)
        {
            _shippingMethodService = shippingMethodService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _shippingMethodService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _shippingMethodService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ShippingMethod shippingMethod)
        {
            await _shippingMethodService.Create(shippingMethod);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ShippingMethod shippingMethod)
        {
            await _shippingMethodService.Update(shippingMethod);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _shippingMethodService.Delete(id);
            return Ok();
        }
    }
}