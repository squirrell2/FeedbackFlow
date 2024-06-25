using FeedbackFlow.Api.Controllers;
using FeedbackFlow.Api.Tests.Fixture;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace FeedbackFlow.Api.Tests
{
    public class HomeControllerTests : IClassFixture<ApiTestFactory>
    {
        private readonly ApiTestFactory _factory;
        private readonly HttpClient _client;

        public HomeControllerTests(ApiTestFactory factory)
        {
            _factory = factory;
            _client = factory.CreateClient();
        }


        [Fact(DisplayName = "Проверка работоспособности Api")]
        public async void Get_ReturnsHelloString()
        {

            // Arrange


            // Act
            var response = await _client.GetAsync("/Home");

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.NotEmpty(responseString);
            Assert.Contains(HomeController.HomeResponse, responseString);
        }
    }
}

