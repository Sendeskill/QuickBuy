using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Arguments.Request;
using QuickBuy.Domain.Contract.Managers;
using System;

namespace QuickBuy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderManager _manager;

        public OrderController(IOrderManager manager)
        {
            _manager = manager;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody]OrderRequest param)
        {
            try
            {
                _manager.Add(param);
                return Ok(new { Message = "Successfully added order" });
            }
            catch (Exception)
            {
                return BadRequest("Unable to add order");
            }
        }
    }
}