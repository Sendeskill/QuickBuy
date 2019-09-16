using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Arguments.Request;
using QuickBuy.Domain.Contract.Managers;
using System;
using System.Collections.Generic;

namespace QuickBuy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _manager;

        public ProductController(IProductManager manager)
        {
            _manager = manager;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody]ProductRequest param)
        {
            try
            {
                _manager.Add(param);
                return Ok(new { Message = "Successfully added product" });
            }
            catch (Exception)
            {
                return BadRequest("Unable to add product");
            }
        }
    }
}