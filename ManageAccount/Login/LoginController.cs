using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HairSalonBookingApp.ManageAccount.Login
{
    [Route("[controller]")]
 [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Logic xử lý đăng nhập ở đây
            return Ok(new { Message = "Login successful" });
        }
    }
}