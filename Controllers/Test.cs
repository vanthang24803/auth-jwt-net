using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.Core.Constant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class Test : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = StaticUserRole.ADMIN)]
        public IActionResult GetHello() {
            return Ok("Hello World");
        }
    }
}