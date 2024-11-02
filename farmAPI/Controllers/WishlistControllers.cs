using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishlistController : ControllerBase
    {
        private readonly IWishlistService _wishlistService;

        public WishlistController(IWishlistService wishlistService)
        {
            _wishlistService = wishlistService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _wishlistService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _wishlistService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Wishlist wishlist)
        {
            await _wishlistService.Create(wishlist);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Wishlist wishlist)
        {
            await _wishlistService.Update(wishlist);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _wishlistService.Delete(id);
            return Ok();
        }
    }
}