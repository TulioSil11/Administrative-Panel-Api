using new_bs_integra.Models;

namespace new_bs_integra.Security.Interfaces
{
    public interface IToken
    {
        UserToken TokenGenerete(BsecFuncionario user);
    }
}
