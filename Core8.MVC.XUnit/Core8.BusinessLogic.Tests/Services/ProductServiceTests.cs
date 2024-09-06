using AutoFixture;
using AutoFixture.AutoNSubstitute;
using Core8.BusinessLogic.Services;
using FluentAssertions;
using NSubstitute;

namespace Core8.BusinessLogic.Tests.Services
{
    public class ProductServiceTests
    {
        private readonly IFixture _fixture;
        private readonly ICustomService _customService;
        private readonly IProductService _productService;

        public ProductServiceTests()
        {
            _fixture = new Fixture()
                .Customize(new AutoNSubstituteCustomization());

            _customService = _fixture.Freeze<ICustomService>();
            _productService = _fixture.Create<ProductService>();
        }

        [Fact]
        public void ProductService_GetProducts()
        {
            var products = _fixture.Build<string>().CreateMany().ToList();
            _customService.GetProducts().Returns(products);

            var result = _productService.GetProducts();

            result.Should().BeEquivalentTo(products);
        }
    }
}
