using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;

        public CartItemController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _cartItemService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _cartItemService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CartItem cartItem)
        {
            await _cartItemService.Create(cartItem);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(CartItem cartItem)
        {
            await _cartItemService.Update(cartItem);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _cartItemService.Delete(id);
            return Ok();
        }
    }
}