using System;
using System.Collections.Generic;

namespace new_bs_integra.Models
{
    public partial class BsecEstoque
    {
        public int IdProduto { get; set; }
        public int IdFilial { get; set; }
        public string TipoProduto { get; set; }
        public decimal? QtDisponivel { get; set; }
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
        public DateTime? DtUltimaEntrada { get; set; }
    }
}
