using new_bs_integra.Models;

namespace new_bs_integra.Repositores.Interfaces
{
    public interface IProductRepository
    {
        (IEnumerable<object>, int) GetProduts(ProductSearch produtSearch);
        IEnumerable<object> GetProdutsById(int id);
        IEnumerable<object> GetPriceByFilial(int idProduct);
        IEnumerable<object> GetStockByFilial(int idProduct);
        object UpdateProdut(Product productDto);

    }
}
