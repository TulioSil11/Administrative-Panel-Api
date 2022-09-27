using System;
using System.Collections.Generic;

namespace new_bs_integra.Models
{
    public partial class BsecFormaparcela
    {
        public int? SeqFormaparcela { get; set; }
        public int SeqCliente { get; set; }
        public int? Numparcela { get; set; }
        public string NomeFormaparcela { get; set; }
        public bool? Status { get; set; }
        public string StringBanco { get; set; }
        public DateTime? DtInsertBs { get; set; }
        public DateTime? DtUpdateBs { get; set; }
        public DateTime? DtDeleteBs { get; set; }
    }
}
