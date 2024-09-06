using AutoFixture;
using AutoFixture.AutoNSubstitute;
using Core8.BusinessLogic.Services;
using Core8.MVC.XUnit.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace Core8.MVC.XUnit.Tests.Controllers
{
    public class HomeControllerTests
    {
        private readonly IFixture _fixture;
        private readonly IProductService _productService;
        private readonly ILogger<HomeController> _logger;
        private readonly HomeController _controller;

        public HomeControllerTests()
        {
            _fixture = new Fixture()
                .Customize(new AutoNSubstituteCustomization());

            _productService = _fixture.Freeze<IProductService>();
            _logger = _fixture.Freeze<ILogger<HomeController>>();

            _controller = new HomeController(_logger, _productService);

        }

        [Fact]
        public void HomeController_Index()
        {
            var products = _fixture.Build<string>().CreateMany().ToList();
            _productService.GetProducts().Returns(products);

            var result = _controller.Index() as ViewResult;

            result.Should().NotBeNull();
            var model = result?.Model as IEnumerable<string>;
            model.Should().BeEquivalentTo(products);
        }
    }
}
