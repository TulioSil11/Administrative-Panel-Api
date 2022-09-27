using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using new_bs_integra.Models;
using new_bs_integra.Services.Interfaces;
using new_bs_integra.Utilitiess;
using System.Linq;

namespace new_bs_integra.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<object>> GetFuncionarios(int index, int length)
        {
            var users = _userService.GetUsers();
            return users is not null ? Ok(new PaginationResponse<object>(users, index, length)): BadRequest(users);
        }

        [HttpPut]
        public ActionResult UpdateUser(UserUpdate userUpdate)
        {
            var updateUser = _userService.UpdateUser(userUpdate);
            return updateUser is not null? Ok(updateUser) : BadRequest();
        }
    }
}
