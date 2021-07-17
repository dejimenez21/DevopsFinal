using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevopsPractice.Services;
using Xunit;

namespace DevopsPractice.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4,3,7,true)]
        [InlineData(2, 2, 4, true)]
        [InlineData(1, 12, 13, true)]
        [InlineData(100, 1000, 1100, true)]
        [InlineData(0, 0, 0, true)]
        [InlineData(1, -1, null, false)] 
        [InlineData(-5, 3, null, false)]
        public void Add_ShouldSumTwoNumbers(int a, int b, double? expected, bool success)
        {
            // Arrange
            var calc = new Calculator();
            double? result;

            //Act
            bool actual = calc.Add(a, b, out result);

            //Assert
            Assert.Equal(expected, result);
            Assert.Equal(actual, success);
        }

        [Theory]
        [InlineData(2,2,0,true)]
        [InlineData(5, 3, 2, true)]
        [InlineData(1000, 500, 500, true)]
        [InlineData(0, 0, 0, true)]
        [InlineData(1, -2, null, false)] 
        [InlineData(-8, 2, null, false)]
        [InlineData(4, 8, null, false)] 
        [InlineData(100, 200, null, false)]
        public void Add_ShouldSubtractTwoNumbers(int a, int b, double? expected, bool success)
        {
            // Arrange
            var calc = new Calculator();
            double? result;

            //Act
            bool actual = calc.Subtract(a, b, out result);

            //Assert
            Assert.Equal(expected, result);
            Assert.Equal(actual, success);
        }
    }
}
