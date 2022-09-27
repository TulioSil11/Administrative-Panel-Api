using System;
using System.Collections.Generic;

namespace new_bs_integra.Models
{
    public partial class BsecFuncionario
    {
        public long IdFuncionario { get; set; }
        public int? IdVendedor { get; set; }
        public string NomeFuncionario { get; set; }
        public int IdSetor { get; set; }
        public string NomeSetor { get; set; }
        public short? IdFilial { get; set; }
        public string Enviafv { get; set; }
        public string Usuariobd { get; set; }
        public string Senhabd { get; set; }
        public string SituacaoErp { get; set; }
        public string Email { get; set; }
        public bool? Status { get; set; }
        public decimal SeqCliente { get; set; }
        public string RowidTb { get; set; }
        public string StringBanco { get; set; }
        public DateTime? DtInsert { get; set; }
        public DateTime? DtUpdate { get; set; }
        public DateTime? DtDelete { get; set; }
        public DateTime? DtInsertBs { get; set; }
        public DateTime? DtUpdateBs { get; set; }
        public DateTime? DtDeleteBs { get; set; }
        public bool? SincInsert { get; set; }
        public bool? SincUpdate { get; set; }
        public bool? SincDelete { get; set; }
        public byte? IdPerfil { get; set; }
        public decimal? DescontoMaxRodape { get; set; }
        public string Tipocargo { get; set; }
    }
}
