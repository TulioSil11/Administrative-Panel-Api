using Microsoft.AspNetCore.Mvc;
using new_bs_integra.Models;
using new_bs_integra.Security;
using new_bs_integra.Security.Interfaces;
using new_bs_integra.DTOs;
using Microsoft.EntityFrameworkCore;
using new_bs_integra.Services.Interfaces;

namespace new_bs_integra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService; 

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<UserToken>>> Login(UserDto userDto)
        {
            var token = await _authService.LoginVerificatio(userDto);
            return token is null ? BadRequest() : Ok(token);
        }
    }
}
