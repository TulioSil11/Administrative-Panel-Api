using Dapper;
using Microsoft.EntityFrameworkCore;
using new_bs_integra.DTOs;
using new_bs_integra.Models;
using new_bs_integra.Repositores.Interfaces;
using new_bs_integra.Security.Interfaces;
using Oracle.ManagedDataAccess.Client;

namespace new_bs_integra.Repositores
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ModelContext _context;
        private readonly IConfiguration _config;
        private readonly string _connection;

        public AuthRepository(ModelContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
            _connection = _config.GetConnectionString("ConnectionStrings:DefaultConnection");
        }

        public BsecFuncionario GetUserForLogin(string User, string password)
        {
            var user = _context.BsecFuncionarios
                .Where(user => user.Usuariobd == User && user.Senhabd == password && user.IdPerfil == 2 && user.Status == true).ToList();

            return user.Count() > 0 ? user.Take(1).First() : null ;

        }
    }
}
