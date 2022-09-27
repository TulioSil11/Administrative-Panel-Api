namespace new_bs_integra.Models
{
    public class ProductsReturn
    {
        public IEnumerable<object> Products { get; set; }
        public int TotalProducts { get; set; }
    }
}
