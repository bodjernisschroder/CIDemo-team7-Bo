using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calc = new();

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Assert.Equal(5, _calc.Add(2, 3));
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            Assert.Equal(1, _calc.Subtract(4, 3));
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            Assert.Equal(12, _calc.Multiply(3, 4));
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            Assert.Equal(2.0, _calc.Divide(4, 2));
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(4, 0));
        }
    }
}
