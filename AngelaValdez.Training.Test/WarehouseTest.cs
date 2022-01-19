using AngelaValdez.Training.API;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace TestProject1
{
    public class WarehouseTest
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly ITestOutputHelper _outputHelper;

        public WarehouseTest(ITestOutputHelper outputHelper)
        {
            _factory = new WebApplicationFactory<Startup>();
            _outputHelper = outputHelper;
        }


        [Fact]
        public async Task GetWarehouse()
        {
            var client = _factory.CreateDefaultClient();
            var response = await client.GetAsync("/api/Warehouse/Warehouse");
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var responseContent = response.Content.ReadAsStringAsync().Result;
            _outputHelper.WriteLine(JsonConvert.SerializeObject(responseContent));
        }
    }
}
