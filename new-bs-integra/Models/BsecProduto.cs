using System;
using System.Collections.Generic;

namespace new_bs_integra.Models
{
    public partial class BsecProduto
    {
        public int IdProduto { get; set; }
        public int? IdProdprincipal { get; set; }
        public string NomeProduto { get; set; }
        public string Nomeecommerce { get; set; }
        public int IdDepartamento { get; set; }
        public int IdSecao { get; set; }
        public string Informacoestecnicas { get; set; }
        public string Dadostecnicos { get; set; }
        public string Tituloecommerce { get; set; }
        public string Subtituloecommerce { get; set; }
        public int? IdMarca { get; set; }
        public string NomeMarca { get; set; }
        public int? IdLinha { get; set; }
        public string NomeLinha { get; set; }
        public int? IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public int? IdSubcategoria { get; set; }
        public string NomeSubcategoria { get; set; }
        public decimal? Pesoembalagem { get; set; }
        public decimal? Litragem { get; set; }
        public string Unidademaster { get; set; }
        public string Ncm { get; set; }
        public string Embalagem { get; set; }
        public string Enviaecommerce { get; set; }
        public string Dirfotoprod { get; set; }
        public string TipoMpAcab { get; set; }
        public decimal? Qtprod { get; set; }
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
        public int? SeqFormaparcela { get; set; }
        public decimal? PesoLiquido { get; set; }
        public decimal? PesoBruto { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Largura { get; set; }
        public decimal? Comprimento { get; set; }
        public decimal? QtminAtacado { get; set; }
        public int? IdProdutoMagento { get; set; }
        public DateTime? Dtvalidadedestaque { get; set; }
        public decimal? Multiplo { get; set; }
        public string Tipoestoque { get; set; }
        public DateTime? Dtexclusao { get; set; }
        public string Obs { get; set; }
        public string Obs2 { get; set; }
        public bool? SincConfig { get; set; }
        public int? IdFornecedor { get; set; }
        public bool? TpEnvio { get; set; }
        public string CodFab { get; set; }
        public int? QtImagensMagento { get; set; }
        public DateTime? DtImagemDir { get; set; }
        public int? QtImagens { get; set; }
        public int? Estgerindisponivelsite { get; set; }
        public string Descricao1 { get; set; }
        public DateTime? DtProdHomeIni { get; set; }
        public DateTime? DtProdHomeFim { get; set; }
        public string Enviacorreios { get; set; }
    }
}
