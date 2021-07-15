using RestSharp.Extensions;
using System;
using TechTalk.SpecFlow;
using RestSharp;
using Xunit;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;

namespace DevopsPractice.Tests.Behavior.Steps
{
    [Binding]
    public class SumSteps
    {
        private HttpClient _client;
        private const string BASE_URL = "https://localhost:5001/";
        private int num1;
        private int num2;
        private string content;


        [Given(@"I input numbers (.*) and (.*)")]
        public void GivenIInputNumbersAnd(int a, int b)
        {
            num1 = a;
            num2 = b;
        }
        
        [When(@"I send sum request")]
        public async Task WhenISendSumRequest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();

            var response = await _client.GetAsync($"{BASE_URL}calculator/sum?num1={num1}&num2={num2}");
            content = await response.Content.ReadAsStringAsync();
        }
        
        [Then(@"the result (.*) should be the sum")]
        public void ThenTheResultShouldBeTheSum(string result)
        {
            Assert.Equal(result, content);
        }
    }
}
