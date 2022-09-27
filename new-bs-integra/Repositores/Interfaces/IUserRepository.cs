using new_bs_integra.Models;

namespace new_bs_integra.Repositores.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<object> GetUsers();
        Task<object> UpdateUser(UserUpdate userUpdate);
    }
}
