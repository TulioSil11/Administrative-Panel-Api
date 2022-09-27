using Microsoft.AspNetCore.Mvc;
using new_bs_integra.DTOs;
using new_bs_integra.Models;
using new_bs_integra.Repositores.Interfaces;
using new_bs_integra.Security.Interfaces;
using new_bs_integra.Services.Interfaces;
using new_bs_integra.Utilites;

namespace new_bs_integra.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _aunthRepository;
        public IToken _token;
        public CriptyKey _criptyKey;

        public AuthService(IAuthRepository authRepository, IToken token, CriptyKey criptyKey)
        {
            _aunthRepository = authRepository;
            _token = token;
            _criptyKey = criptyKey;
        }
        public  async Task<UserToken> LoginVerificatio(UserDto user)
        {
            if (user is not null)
            {
                var passwordCripty = await _criptyKey.Cripy(user.Password, user.UserName);

                var usuario =  _aunthRepository.GetUserForLogin(user.UserName ??= "", passwordCripty ??= "");

                if (usuario is not null) return _token.TokenGenerete(usuario);
            }
            return null;                      
        }
    }
}
