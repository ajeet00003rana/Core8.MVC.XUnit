namespace Core8.BusinessLogic.Services
{
    public interface IProductService
    {
        List<string> GetProducts();
    }

    public class ProductService : IProductService
    {
        private readonly ICustomService _customService;

        public ProductService(ICustomService customService)
        {
            _customService = customService;
        }

        public List<string> GetProducts()
        {
            var customProducts= _customService.GetProducts();
            customProducts.Add("Nokia");
            return customProducts;
        }
    }
}
