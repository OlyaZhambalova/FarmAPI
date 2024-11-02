using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService _userRoleService;

        public UserRoleController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userRoleService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _userRoleService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserRole userRole)
        {
            await _userRoleService.Create(userRole);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserRole userRole)
        {
            await _userRoleService.Update(userRole);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userRoleService.Delete(id);
            return Ok();
        }
    }
}