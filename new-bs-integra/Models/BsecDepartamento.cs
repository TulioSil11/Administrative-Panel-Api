using System;
using System.Collections.Generic;

namespace new_bs_integra.Models
{
    public partial class BsecDepartamento
    {
        public int IdDepto { get; set; }
        public string NomeDepto { get; set; }
        public string Enviaecommerce { get; set; }
        public int? SeqCatalogoServico { get; set; }
        public bool? Status { get; set; }
        public decimal SeqCliente { get; set; }
        public string RowidTb { get; set; }
        public string StringBanco { get; set; }
        public DateTime? DtInsert { get; set; }
        public DateTime? DtUpdate { get; set; }
        public DateTime? DtDelete { get; set; }
        public bool? SincInsert { get; set; }
        public bool? SincUpdate { get; set; }
        public bool? SincDelete { get; set; }
        public DateTime? DtInsertBs { get; set; }
        public DateTime? DtUpdateBs { get; set; }
        public DateTime? DtDeleteBs { get; set; }
        public int? IdDeptoMagento { get; set; }
    }
}
