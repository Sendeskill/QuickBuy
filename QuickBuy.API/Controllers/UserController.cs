using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Arguments.Request;
using QuickBuy.Domain.Contract.Managers;
using System;

namespace QuickBuy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _manager;

        public UserController(IUserManager manager)
        {
            _manager = manager;
        }

        [HttpPost("add")]
        public IActionResult Register([FromBody]UserRequest param)
        {
            try
            {
                _manager.Register(param);
                return Ok(new { Message = "User successfully registered" });
            }
            catch (Exception)
            {
                return BadRequest("Unable to register user");
            }
        }
    }
}