using System;
using System.Collections.Generic;

namespace new_bs_integra.Models
{
    public partial class BsecVendedor
    {
        public byte IdVendedor { get; set; }
        public string NomeVendedor { get; set; }
        public int? Matricula { get; set; }
        public string Usuariobd { get; set; }
        public string Senhabd { get; set; }
        public string Tipovend { get; set; }
        public byte IdSupervisor { get; set; }
        public string NomeSupervisor { get; set; }
        public string Email { get; set; }
        public string Bloqueio { get; set; }
        public decimal? Proxnumped { get; set; }
        public int? Proxnumpedforca { get; set; }
        public int? IdFilial { get; set; }
        public bool? Status { get; set; }
        public int SeqCliente { get; set; }
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
        public int? IdClienteMagento { get; set; }
        public string Telefone { get; set; }
        public bool? Tpatacarejo { get; set; }
        public DateTime? Dttermino { get; set; }
        public string Telefone1 { get; set; }
    }
}
