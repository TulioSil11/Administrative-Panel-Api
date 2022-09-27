using Newtonsoft.Json;

namespace new_bs_integra.Models
{
    public class ProductSearch
    {
        public int CodigoCatalogo { get; set; }

        public int CodigoDepartamento { get; set; }

        [JsonRequired]
        public int Filial { get; set; }

        public string Pesquisa { get; set; }

        public int OrdenarAz { get; set; }

        public int OrdenarZa { get; set; }

        public int OrdenarPrecoMaior { get; set; }

        public int OrdenarPrecoMenor { get; set; }

        public decimal PrecoInicial { get; set; }

        public decimal PrecoFinal { get; set; }

        [JsonRequired]
        public int LinhaInicial { get; set; }

        [JsonRequired]
        public int Intervalo { get; set; }
    }
}
