using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HairSalonBookingApp.ManageAccount.Register
{
     [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(string username, string password, string email)
        {
            // Logic xử lý đăng ký người dùng
            return Ok(new { Message = "Registration successful" });
        }
    }
}