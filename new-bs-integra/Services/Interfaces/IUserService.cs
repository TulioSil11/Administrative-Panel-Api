using Microsoft.AspNetCore.Mvc;
using new_bs_integra.Models;

namespace new_bs_integra.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<object> GetUsers();
        object UpdateUser(UserUpdate userUpdate);
    }
}
