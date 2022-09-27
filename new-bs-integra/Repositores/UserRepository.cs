using new_bs_integra.Models;
using new_bs_integra.Repositores.Interfaces;
using new_bs_integra.Utilites;

namespace new_bs_integra.Repositores
{
    public class UserRepository : IUserRepository
    {
        private readonly ModelContext _context;
        private readonly CriptyKey _criptyKey;

        public UserRepository(ModelContext context, CriptyKey criptyKey)
        {
            _context = context;
            _criptyKey = criptyKey;
        }

        public IEnumerable<object> GetUsers()
        {
            var query = (from funcionario in _context.BsecFuncionarios
                        join vendedor in _context.BsecVendedors on funcionario.IdVendedor equals vendedor.IdVendedor
                        join perfil in _context.BsecUsuarioPerfils on funcionario.IdPerfil ?? 0 equals perfil.IdPerfil
                        select new
                        {
                            funcionario.IdFuncionario,
                            funcionario.Usuariobd,
                            funcionario.NomeFuncionario,
                            funcionario.DtInsert,
                            funcionario.SeqCliente,
                            funcionario.Status,
                            NomeVendedor = vendedor.NomeVendedor ?? "",
                            Descricao = perfil.Descricao ?? "",
                            IdPerfil = perfil.IdPerfil.ToString() ?? "",
                            DescontoMaxRodape = funcionario.DescontoMaxRodape.ToString() ?? ""
                        }).ToList();

            return query;
        }

        public async Task<object> UpdateUser(UserUpdate userUpdate)
        {
            var keyCripty = await _criptyKey.Cripy(userUpdate.Senha, userUpdate.Login);
            if (keyCripty == null) return null;

            var user = _context.BsecFuncionarios.First(user => user.IdFuncionario == userUpdate.IdFuncionario && user.SeqCliente == 10);
            user.IdFuncionario = userUpdate.IdFuncionario;
            user.IdVendedor = userUpdate.IdVendedor;
            user.Usuariobd = userUpdate.Login;
            user.Senhabd = keyCripty;
            user.IdPerfil = userUpdate.UserMasterOurOperador;
            user.DescontoMaxRodape = userUpdate.DescontoMaximoRodape;            

            _context.SaveChanges();

            return user;
        }
    }
}
