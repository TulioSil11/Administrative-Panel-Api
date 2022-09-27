using new_bs_integra.Models;
using new_bs_integra.Repositores.Interfaces;
using System.Data.Entity;

namespace new_bs_integra.Repositores
{
    public class ProductRepository : IProductRepository
    {
        private readonly ModelContext _context;

        public ProductRepository(ModelContext context)
        {
            _context = context;
        }

        public IEnumerable<object> GetPriceByFilial(int idProduct) =>       
           (from precoRegular in _context.BsecPrecoRegulars
                    where precoRegular.IdProduto == idProduct &&
                          precoRegular.SeqCliente == 10
                    select new { precoRegular }).ToList().OrderBy(contex => contex.precoRegular.IdRegiao) ;

        public IEnumerable<object> GetStockByFilial(int idProduct) =>
            (from estoque in _context.BsecEstoques
             where estoque.IdProduto == idProduct &&
                    estoque.SeqCliente == 10
             select new { estoque }).ToList().OrderBy(contex => contex.estoque.IdFilial);

        public (IEnumerable<object>, int) GetProduts(ProductSearch produtSearch)
        {
            var query = from produto in _context.BsecProdutos
                        join departamento in _context.BsecDepartamentos on produto.IdDepartamento equals departamento.IdDepto
                        join estoque in _context.BsecEstoques.Where(p => p.IdFilial == produtSearch.Filial) on produto.IdProduto equals estoque.IdProduto
                        join secao in _context.BsecSecaos on produto.IdSecao equals secao.IdSecao
                        join precoRegular in _context.BsecPrecoRegulars on produto.IdProduto equals precoRegular.IdProduto
                        join formaParcela in _context.BsecFormaparcela on (produto.SeqFormaparcela ?? 12) equals formaParcela.SeqFormaparcela


                        select new
                        {
                            Preco = precoRegular.Preco ?? 0,
                            SKU = produto.IdProduto,
                            produto.IdProdprincipal,
                            produto.NomeProduto,
                            produto.Nomeecommerce,
                            produto.IdDepartamento,
                            departamento.NomeDepto,
                            produto.IdSecao,
                            secao.NomeSecao,
                            produto.Informacoestecnicas,
                            produto.Dadostecnicos,
                            produto.Tituloecommerce,
                            produto.Subtituloecommerce,
                            produto.IdMarca,
                            produto.IdLinha,
                            produto.NomeLinha,
                            produto.IdCategoria,
                            produto.NomeCategoria,
                            produto.IdSubcategoria,
                            produto.NomeSubcategoria,
                            produto.Pesoembalagem,
                            produto.Litragem,
                            produto.Unidademaster,
                            produto.Ncm,
                            produto.CodFab,
                            produto.Embalagem,
                            produto.Dirfotoprod,
                            produto.SeqCliente,
                            produto.Obs,
                            departamento.SeqCatalogoServico,
                            NumParcela = formaParcela.Numparcela ?? 0,
                            formaParcela.NomeFormaparcela,
                            Multiplo = ((produto.Multiplo ?? 1) < 1? 1 : produto.Multiplo), 
                            produto.Tipoestoque,
                            estoque.QtDisponivel,
                            IdFilial = precoRegular.IdRegiao,                          
                        };

            query = query.Where(p => p.IdFilial == produtSearch.Filial && p.SeqCliente == 10 && p.Obs != "PV");

            if(produtSearch.CodigoDepartamento != 0)
            {
                query = query.Where(p => p.IdDepartamento == produtSearch.CodigoDepartamento);
            }

            if(produtSearch.PrecoInicial != 0 && produtSearch.PrecoFinal != 0)
            {
                query = query.Where(p => p.Preco >= produtSearch.PrecoInicial && p.Preco <= produtSearch.PrecoFinal);
            }

            if(produtSearch.CodigoCatalogo != 0)
            {
                query = query.Where(p => p.SeqCatalogoServico == produtSearch.CodigoCatalogo);
            }

            if(produtSearch.Pesquisa is not null
                && produtSearch.Pesquisa.All(char.IsDigit))
            {
                query = query.Where(p => p.SKU == int.Parse(produtSearch.Pesquisa) || p.Nomeecommerce.ToUpper().Contains(produtSearch.Pesquisa));
            }
            else if(produtSearch.Pesquisa is not null)
            {
                query = query.Where(p => p.NomeProduto.ToUpper().Contains(produtSearch.Pesquisa));
            }

            if (produtSearch.OrdenarAz == 1)
            {
                query = query.OrderBy(p => p.NomeProduto).Reverse();
            }else if(produtSearch.OrdenarZa == 1)
            {
                query = query.OrderByDescending(p => p.NomeProduto).Reverse();
            }

            if (produtSearch.OrdenarPrecoMaior == 1)
            {
                query = query.OrderBy(p => p.Preco).Reverse();
            }else if (produtSearch.OrdenarPrecoMenor == 1)
            {
                query = query.OrderByDescending(p => p.Preco).Reverse();
            }

            var totalRecords = query.Count();

            query = query.OrderBy(p => p.SKU)
                         .Skip(produtSearch.LinhaInicial)
                         .Take(produtSearch.Intervalo);

            var pruduts = query.ToList();

            return (pruduts, totalRecords);
        }

        public IEnumerable<object> GetProdutsById(int id) =>        
            (_context.BsecProdutos.Where(produt => produt.IdProduto == id).Select(produt => new
            {
                produt.IdProduto,
                produt.Nomeecommerce,
                produt.NomeProduto,
                produt.NomeMarca,
                produt.Status,
                produt.DtProdHomeIni,
                produt.DtProdHomeFim,
                produt.Dirfotoprod,
                produt.TipoMpAcab,
                produt.SeqCliente,
                produt.PesoLiquido,
                produt.PesoBruto,
                produt.Multiplo,
                produt.Tipoestoque,
                produt.QtImagens,
                produt.QtminAtacado,
                produt.Enviaecommerce,
                produt.Embalagem,
                produt.Informacoestecnicas,
                produt.Dadostecnicos,
                produt.Altura,
                produt.Largura,
                produt.Comprimento,
                produt.Pesoembalagem,
                produt.IdCategoria,
                produt.IdDepartamento,
                produt.IdSecao
            })).ToList();



        public object UpdateProdut(Product productDto)
        {
            var product = _context.BsecProdutos
                .First(product => product.IdProduto == productDto.CodigoProduto && 
                product.SeqCliente == 10);

            var estoque = _context.BsecEstoques
                .First(estoque => estoque.IdProduto == productDto.CodigoProduto &&
                estoque.IdFilial == productDto.CodigoFilial && 
                estoque.SeqCliente == 10);

            var precoRegular = _context.BsecPrecoRegulars
                .First(precoRegular => precoRegular.IdProduto == productDto.CodigoProduto &&
                precoRegular.IdRegiao == productDto.CodigoFilial &&
                precoRegular.SeqCliente == 10);

            product.NomeProduto = productDto.NomeProduto;
            product.Descricao1 = productDto.NomeProdutoResumido;
            product.IdDepartamento = productDto.CodigoDepartamento;
            product.IdSecao = productDto.CodigoSecao;
            product.IdCategoria = productDto.CodigoCategoria;
            product.Dadostecnicos = productDto.Descricao;
            precoRegular.Preco = productDto.Preco;
            estoque.QtDisponivel = productDto.Estoque;
            product.Multiplo = productDto.Multiplo;
            product.Tipoestoque = productDto.TipoEstoque;
            product.QtminAtacado = product.QtminAtacado;
            product.PesoBruto = productDto.PesoBruto;
            product.PesoLiquido = productDto.PesoLiquido;
            product.Pesoembalagem = productDto.PesoEmbalagemProduto;
            product.Embalagem = productDto.Embalagem;
            product.Altura = productDto.Altura;
            product.Largura = productDto.Largura;
            product.Comprimento = productDto.Comprimento;
            product.IdMarca = productDto.IdMarca;
            product.Status = productDto.Ativo;
            product.TpEnvio = productDto.ExibirEcommerceOrPortal;
            product.DtProdHomeIni = productDto.DataInicialExibicao;
            product.DtProdHomeIni = productDto.DataFinalExibicao;

            _context.SaveChanges();

            return product;
        }
    }
}
