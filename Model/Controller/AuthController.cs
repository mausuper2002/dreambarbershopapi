using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HairSalonBookingApp.Model.Controller
{
    [Route("[controller]")]// Controllers/AuthController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public AuthController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            var user = _userRepository.ValidateUser(loginDto.Username, loginDto.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            // Generate JWT token (for simplicity, returning role for now)
            return Ok(new { role = user.Role });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterDto registerDto)
        {
            _userRepository.RegisterUser(registerDto.Username, registerDto.Password, registerDto.Role);
            return Ok("Registration successful");
        }
    }

    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class RegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

}