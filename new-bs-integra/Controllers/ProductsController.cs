using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_bs_integra.Models;
using new_bs_integra.Services.Interfaces;

namespace new_bs_integra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _produtService;
        public ProductsController(IProductService produtService)
        {
            _produtService = produtService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<object>> GetProduts ([FromQuery] ProductSearch produtSearch)
        {
            var products = _produtService.GetProduts(produtSearch);

            return Ok(new ProductsReturn 
            { 
              Products = products.Item1,
              TotalProducts = products.Item2
            });
        }


        [HttpGet("ById")]
        public ActionResult<IEnumerable<object>> GetProdutById(int idProduct)
        {
            var produts = _produtService.GetProdutsById(idProduct);

            return produts is not null ? Ok(produts) : BadRequest();
        }

        [HttpGet("PriceOfProductByFilial")]
        public ActionResult<IEnumerable<object>>GetPriceOfProduct(int idProduct)
        {
            var products = _produtService.GetPriceByFilial(idProduct);
            return products is not null? Ok(products) : BadRequest();
        }

        [HttpGet("StockOfProductByFilial")]
        public ActionResult<IEnumerable<object>> GetStockOfProduct(int idProduct)
        {
            var products = _produtService.GetStockByFilial(idProduct);

            return products is not null ? Ok(products) : BadRequest();
        }

        [HttpPut]
        public ActionResult<IEnumerable<object>> UpdateProduct(Product productUpdate)
        {
            var ProductToUpdate = _produtService.UpdateProduct(productUpdate);

            return ProductToUpdate is not null? Ok(ProductToUpdate): BadRequest();
        }
    }
}
