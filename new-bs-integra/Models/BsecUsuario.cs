using System;
using System.Collections.Generic;

namespace new_bs_integra.Models
{
    public partial class BsecUsuario
    {
        public int SeqCliente { get; set; }
        public int SeqUsuario { get; set; }
        public int IdVendedor { get; set; }
        public int IdFuncionario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }
        public bool PrimeiraVez { get; set; }
        public bool OrigemCadastro { get; set; }
        public DateTime Dtcadastro { get; set; }
        public bool UsuarioMaster { get; set; }
        public DateTime DtInsertBs { get; set; }
        public DateTime DtUpdateBs { get; set; }
        public DateTime DtDeleteBs { get; set; }
        public int IdCliente { get; set; }
        public bool UsuarioOp { get; set; }
        public int IdVendedorVinculado { get; set; }
        public decimal PercDescRodape { get; set; }
    }
}
