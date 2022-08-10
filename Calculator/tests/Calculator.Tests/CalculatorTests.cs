using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldDoAdiition()
        {
            double result = Calculator.DoOperation(1, 2, "a");
            Assert.Equal(3, result);
        }

        [Fact]
        public void ShouldDoMultiplication()
        {
            double result = Calculator.DoOperation(3, 2, "m");
            Assert.Equal(6, result);
        }
    }
}
