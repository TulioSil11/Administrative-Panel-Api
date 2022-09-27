using Microsoft.AspNetCore.Mvc;
using new_bs_integra.DTOs;
using new_bs_integra.Models;

namespace new_bs_integra.Services.Interfaces
{
    public interface IAuthService
    {
        Task<UserToken> LoginVerificatio(UserDto user);
    }
}
