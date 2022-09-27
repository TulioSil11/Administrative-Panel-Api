using new_bs_integra.Models;

namespace new_bs_integra.Services.Interfaces
{
    public interface IProductService
    {
        (IEnumerable<object>, int) GetProduts(ProductSearch produtSearch);
        IEnumerable<object> GetProdutsById(int idProduct);
        IEnumerable<object> GetPriceByFilial(int idProduct);
        IEnumerable<object> GetStockByFilial(int idProduct);
        object UpdateProduct(Product productUpdate);

    }
}
