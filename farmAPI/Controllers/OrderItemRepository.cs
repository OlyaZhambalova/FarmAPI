using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace farmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemService _orderItemService;

        public OrderItemController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _orderItemService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _orderItemService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(OrderItem orderItem)
        {
            await _orderItemService.Create(orderItem);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(OrderItem orderItem)
        {
            await _orderItemService.Update(orderItem);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _orderItemService.Delete(id);
            return Ok();
        }
    }
}