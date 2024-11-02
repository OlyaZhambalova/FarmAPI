using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        private readonly IAdressBookService _addressBookService;

        public AddressBookController(IAdressBookService addressBookService)
        {
            _addressBookService = addressBookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _addressBookService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _addressBookService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddressBook addressBook)
        {
            await _addressBookService.Create(addressBook);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(AddressBook addressBook)
        {
            await _addressBookService.Update(addressBook);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _addressBookService.Delete(id);
            return Ok();
        }
    }
}