namespace Core8.BusinessLogic.Services
{
    public interface ICustomService
    {
        List<string> GetProducts();
    }
    internal class CustomService : ICustomService
    {
        public List<string> GetProducts()
        {
            return new List<string>
            {
                "Apple",
                "Samsung",
                "Blackberry",
                "OnePlus",
            };
        }
    }
}
