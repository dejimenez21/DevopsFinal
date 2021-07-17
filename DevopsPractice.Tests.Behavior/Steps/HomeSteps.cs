
using System;
using TechTalk.SpecFlow;
using Xunit;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DevopsPractice.Tests.Behavior.Steps
{
    [Binding]
    public class HomeSteps
    {
        class JsonResult{
            public string Nombre { get; set; }
            public string Matricula { get; set; }
        }
        private HttpClient _client;
        private const string BASE_URL = "https://localhost:5001/";
        private JsonResult content;

        [Given(@"I input the app url")]
        public void GivenIInputAppUrl()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();
        }
        
        [When(@"I send the get request")]
        public async Task WhenISendTheGetRequest()
        {
            var response = await _client.GetAsync($"{BASE_URL}");
            var jsonString = await response.Content.ReadAsStringAsync();
            content = JsonConvert.DeserializeObject<JsonResult>(jsonString);
        }
        
        [Then(@"The result should be '(.*)' '(.*)'")]
        public void ThenTheResultShouldBe(string nombre, string matricula)
        {
            Assert.Equal(nombre, content.Nombre);
            Assert.Equal(matricula, content.Matricula);
        }
    }
}
