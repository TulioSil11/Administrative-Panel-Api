using Dapper;
using new_bs_integra.Models;
using Oracle.ManagedDataAccess.Client;

namespace new_bs_integra.Utilites
{
    public class CriptyKey
    {
        public string _connection;
        public CriptyKey(IConfiguration configuration)
        {
            _connection = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }

        public async Task<string> Cripy(string Key, string Login)
        {
            KeyCripy key = new KeyCripy();

            try
            {
                using (var conexao = new OracleConnection(_connection))
                {
                    var query = new System.Text.StringBuilder();
                    query.AppendLine($"select BSCASARIOS.crypt('{Key}', '{Login}') Key from dual");

                    key = await conexao.QueryFirstOrDefaultAsync<KeyCripy>(query.ToString());
                }
            }
            catch
            {
                return null;
            }

            return key.Key;
        }
    }
}
