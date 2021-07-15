using RestSharp.Extensions;
using System;
using TechTalk.SpecFlow;
using RestSharp;
using Xunit;

namespace DevopsPractice.Tests.Behavior.Steps
{
    [Binding]
    public class SumSteps
    {
        private const string BASE_URL = "https://localhost:5001/";
        private IRestResponse response;
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
        public void WhenISendSumRequest()
        {
            var client = new RestClient(BASE_URL);

            var request = new RestRequest($"calculator/sum?num1={num1}&num2={num2}", Method.GET);

            content = client.Execute(request).Content;

        }
        
        [Then(@"the result (.*) should be the sum")]
        public void ThenTheResultShouldBeTheSum(string result)
        {
            Assert.Equal(result, content);
        }
    }
}
