using new_bs_integra.Models;
using new_bs_integra.Repositores;
using new_bs_integra.Repositores.Interfaces;
using new_bs_integra.Services.Interfaces;
using new_bs_integra.Utilites;

namespace new_bs_integra.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _produtRepository;

        public ProductService(IProductRepository produtRepository)
        {
            _produtRepository = produtRepository;
        }

        public IEnumerable<object> GetPriceByFilial(int idProduct) =>
         _produtRepository.GetPriceByFilial(idProduct);

        public (IEnumerable<object>, int) GetProduts(ProductSearch produtSearch) =>
          _produtRepository.GetProduts(produtSearch);

        public IEnumerable<object> GetProdutsById(int id) =>
         _produtRepository.GetProdutsById(id);

        public IEnumerable<object> GetStockByFilial(int idProduct) =>
            _produtRepository.GetStockByFilial(idProduct);


        public object UpdateProduct(Product productUpdate)
        {
            if (!CheckProperties.ItsNull(productUpdate)) return null;

            var ProductToUpdate = _produtRepository.UpdateProdut(productUpdate);

            return ProductToUpdate;
        }
    }
}
