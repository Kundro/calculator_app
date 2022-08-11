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

        [Fact]
        public void ShouldDoDivision()
        {
            double result = Calculator.DoOperation(3, 2, "d");
            Assert.Equal(1.5, result);
        }

        [Fact]
        public void ShouldDoSubtraction()
        {
            double result = Calculator.DoOperation(3, 2, "s");
            Assert.Equal(1, result);
        }

        [Fact]
        public void ShouldNotDoDivision()
        {
            double result = Calculator.DoOperation(3, 0, "d");
            Assert.Equal(double.NaN, result);
        }

        [Fact]
        public void ShouldNotDoOperation1()
        {
            double result = Calculator.DoOperation(4, 2, "");
            Assert.Equal(double.NaN, result);
        }

        [Fact]
        public void ShouldNotDoOperation2()
        {
            double result = Calculator.DoOperation(8, 4, "da");
            Assert.Equal(double.NaN, result);
        }
    }
}
