using Newtonsoft.Json;

namespace new_bs_integra.Models
{
    public class Product
    {
        [JsonRequired]
        public string NomeProduto { get; set; }
        public string NomeProdutoResumido { get; set; }
        public int CodigoProduto { get; set; }
        public int CodigoFilial { get; set; }
        public int CodigoDepartamento { get; set; }
        public int CodigoSecao { get; set; }
        public int CodigoCategoria { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int Multiplo { get; set; }
        public string TipoEstoque { get; set; }
        public int QuantidadeMinimaAtacado { get; set; }
        public bool PossuiPreco { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal PesoLiquido { get; set; }
        public decimal PesoEmbalagemProduto { get; set; }
        public string Embalagem { get; set; }
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public decimal Comprimento { get; set; }
        public int IdMarca { get; set; }
        public bool Ativo { get; set; }
        public bool ExibirEcommerceOrPortal { get; set; }
        public DateTime DataInicialExibicao { get; set; }
        public DateTime DataFinalExibicao { get; set; }

    }
}
