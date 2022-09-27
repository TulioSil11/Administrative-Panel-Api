using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using new_bs_integra.Models;
using new_bs_integra.Security.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace new_bs_integra.Security
{
    public class Token : IToken
    {
        private readonly IConfiguration _configuration;

        private readonly TokenConfiguration _tokenConfiguration;

        private readonly Jwt_Key _jwtKey;
        public Token(IConfiguration configuration,
                     IOptions<TokenConfiguration> tokenConfiguration,
                     IOptions<Jwt_Key>  jwtKey)
        {
            _configuration = configuration;
            _tokenConfiguration = tokenConfiguration.Value;
            _jwtKey = jwtKey.Value;
        }

        public UserToken TokenGenerete(BsecFuncionario user)
        {

            var clains = new[]
            {
                 new Claim(JwtRegisteredClaimNames.UniqueName, user.Usuariobd),
                 new Claim("Brunsker", "Brunsker"),
                 new Claim("AcessAdmin", $"{user.IdPerfil}"),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

            };


            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_jwtKey.Key)
                );

            var credenciais = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expiration = DateTime.UtcNow.AddHours(double.Parse(_tokenConfiguration.ExpireHours.ToString()));

            JwtSecurityToken token = new JwtSecurityToken(
              issuer: _tokenConfiguration.Issuer,
              audience: _tokenConfiguration.Audience,
              claims: clains,
              expires: expiration,
              signingCredentials: credenciais);

            return new UserToken()
            {
                UserName = user.Usuariobd,
                User = user.NomeFuncionario,
                Authenticated = true,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration,
                Message = "Token JWT OK",
            };
        }
    }
}
