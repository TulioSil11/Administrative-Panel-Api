using new_bs_integra.DTOs;
using new_bs_integra.Models;

namespace new_bs_integra.Repositores.Interfaces
{
    public interface IAuthRepository
    {
        BsecFuncionario GetUserForLogin(string user, string password);

    }
}
