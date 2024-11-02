using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _cartService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _cartService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Cart cart)
        {
            await _cartService.Create(cart);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Cart cart)
        {
            await _cartService.Update(cart);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _cartService.Delete(id);
            return Ok();
        }
    }
}