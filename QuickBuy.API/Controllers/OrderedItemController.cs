using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Arguments.Request;
using QuickBuy.Domain.Contract.Managers;
using System;

namespace QuickBuy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderedItemController : ControllerBase
    {
        private readonly IOrderedItemManager _manager;

        public OrderedItemController(IOrderedItemManager manager)
        {
            _manager = manager;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody]OrderedItemRequest param)
        {
            try
            {
                _manager.Add(param);
                return Ok(new { Message = "Successfully added ordered item" });
            }
            catch (Exception)
            {
                return BadRequest("Unable to add ordered item");
            }
        }
    }
}