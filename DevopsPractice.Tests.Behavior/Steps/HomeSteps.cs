
using System;
using TechTalk.SpecFlow;
using Xunit;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;

namespace DevopsPractice.Tests.Behavior.Steps
{
    [Binding]
    public class HomeSteps
    {
        private HttpClient _client;
        private const string BASE_URL = "https://localhost:5001/";
        private string content;


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
            content = await response.Content.ReadAsStringAsync();
        }
        
        [Then(@"The result should be '(.*)'")]
        public void ThenTheResultShouldBe(string result)
        {
            Assert.Equal(result, content);
        }
    }
}
