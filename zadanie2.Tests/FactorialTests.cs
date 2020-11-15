using System;
using Xunit;

namespace zadanie2.Tests
{
    public class FactorialTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(6, 720)]
        [InlineData(7, 5040)]
        [InlineData(8, 40320)]
        public void CalculateIterativeTest(ulong n, ulong expectedResult)
        {
            var result = Factorial.CalculateIterative(n);

            Assert.Equal(expectedResult, result);
        }
        
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(6, 720)]
        [InlineData(7, 5040)]
        [InlineData(8, 40320)]
        public void CalculateRecursiveTest(ulong n, ulong expectedResult)
        {
            var result = Factorial.CalculateRecursive(n);

            Assert.Equal(expectedResult, result);
        }
    }
}