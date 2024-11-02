using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        private readonly IFavoriteService _favoriteService;

        public FavoriteController(IFavoriteService favoriteService)
        {
            _favoriteService = favoriteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _favoriteService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _favoriteService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Favorite favorite)
        {
            await _favoriteService.Create(favorite);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Favorite favorite)
        {
            await _favoriteService.Update(favorite);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _favoriteService.Delete(id);
            return Ok();
        }
    }
}