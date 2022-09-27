using Microsoft.AspNetCore.Mvc;
using new_bs_integra.Models;
using new_bs_integra.Repositores.Interfaces;
using new_bs_integra.Services.Interfaces;
using new_bs_integra.Utilites;
using System.Data.Entity;

namespace new_bs_integra.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public IEnumerable<object> GetUsers() =>
        _userRepository.GetUsers();

        public object UpdateUser(UserUpdate userUpdate)
        {
            if (!CheckProperties.ItsNull(userUpdate)) return null;

            var update = _userRepository.UpdateUser(userUpdate);

            return update;
        }
    }
}
