
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
    public class CalculateSteps
    {
        protected class JsonResponse{
            public string result { get; set; }
        }

        protected HttpClient _client;
        protected const string BASE_URL = "https://localhost:5001/";
        protected int num1;
        protected int num2;
        protected JsonResponse content;

        #region GenericSteps
        [Given(@"I input numbers (.*) and (.*)")]
        public void GivenIInputNumbersAnd(int a, int b)
        {
            num1 = a;
            num2 = b;
        }
        # endregion
        
        #region SumSteps
        [When(@"I send sum request")]
        public async Task WhenISendSumRequest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();

            var response = await _client.GetAsync($"{BASE_URL}calculator/sum?num1={num1}&num2={num2}");
            var jsonString = await response.Content.ReadAsStringAsync();
            content = JsonConvert.DeserializeObject<JsonResponse>(jsonString);
            
        }
        
        [Then(@"the result (.*) should be the sum")]
        public void ThenTheResultShouldBeTheSum(string result)
        {
            Assert.Equal(result, content.result);
        }
        #endregion

        #region SubtractSteps
        [When(@"I send subtract request")]
        public async Task WhenISendSubtractRequest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();

            var response = await _client.GetAsync($"{BASE_URL}calculator/subtract?num1={num1}&num2={num2}");
            var jsonString = await response.Content.ReadAsStringAsync();
            content = JsonConvert.DeserializeObject<JsonResponse>(jsonString);
            
        }
        
        [Then(@"the result (.*) should be the subtraction")]
        public void ThenTheResultShouldBeTheSubtraction(string result)
        {
            Assert.Equal(result, content.result);
        }
        #endregion

        #region MultiplySteps
        [When(@"I send multiply request")]
        public async Task WhenISendMultiplyRequest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();

            var response = await _client.GetAsync($"{BASE_URL}calculator/multiply?num1={num1}&num2={num2}");
            var jsonString = await response.Content.ReadAsStringAsync();
            content = JsonConvert.DeserializeObject<JsonResponse>(jsonString);
            
        }
        
        [Then(@"the result (.*) should be the multiplication")]
        public void ThenTheResultShouldBeTheMultiplication(string result)
        {
            Assert.Equal(result, content.result);
        }
        #endregion

        #region DivideSteps
        [When(@"I send divide request")]
        public async Task WhenISendDivideRequest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();

            var response = await _client.GetAsync($"{BASE_URL}calculator/divide?num1={num1}&num2={num2}");
            var jsonString = await response.Content.ReadAsStringAsync();
            content = JsonConvert.DeserializeObject<JsonResponse>(jsonString);
            
        }
        
        [Then(@"the result (.*) should be the division")]
        public void ThenTheResultShouldBeTheDivision(string result)
        {
            Assert.Equal(result, content.result);
        }
        #endregion
    }
}
