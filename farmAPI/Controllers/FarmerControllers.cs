using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmerController : ControllerBase
    {
        private readonly IFamersService _farmerService;

        public FarmerController(IFamersService farmerService)
        {
            _farmerService = farmerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _farmerService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _farmerService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Farmer farmer)
        {
            await _farmerService.Create(farmer);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Farmer farmer)
        {
            await _farmerService.Update(farmer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _farmerService.Delete(id);
            return Ok();
        }
    }
}