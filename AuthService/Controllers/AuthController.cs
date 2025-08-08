using AuthService.DTO;
using AuthService.Models;
using AuthService.Services;
using AuthService.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {   
        private readonly IAuthenticateService authService;
        public AuthController(IAuthenticateService authService)
        {
            this.authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            var token = await authService.LoginUserAsync(model);
            if (token == null)
                return Unauthorized("Invalid username or password");

            return Ok(new { token });
        }
    }
}
