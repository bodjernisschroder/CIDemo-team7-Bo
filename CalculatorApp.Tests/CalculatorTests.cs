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

        [Fact]
        public void Power_ReturnsCorrectResult()
        {
            var result = _calc.Power(2, 3);
            Assert.Equal(8, result, precision: 5);
        }

        [Fact]
        public void Power_WithZeroExponent_ReturnsOne()
        {
            var result = _calc.Power(5, 0);
            Assert.Equal(1, result, precision: 5);
        }

        [Fact]
        public void Power_WithNegativeExponent_ReturnsFraction()
        {
            var result = _calc.Power(2, -2);
            Assert.Equal(0.25, result, precision: 5);
        }

        [Fact]
        public void SquareRoot_ReturnsCorrectResult()
        {
            var result = _calc.SquareRoot(25);
            Assert.Equal(5, result, precision: 5);
        }

        [Fact]
        public void SquareRoot_Zero_ReturnsZero()
        {
            var result = _calc.SquareRoot(0);
            Assert.Equal(0, result, precision: 5);
        }

        [Fact]
        public void SquareRoot_Negative_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _calc.SquareRoot(-4));
        }
        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(5, 0, 1)]
        [InlineData(2, -2, 0.25)]
        [InlineData(-2, 2, 4)]
        [InlineData(-2, 3, -8)]
        public void Power_ReturnsExpectedResults(double a, double b, double expected)
        {
            var result = _calc.Power(a, b);
            Assert.Equal(expected, result, precision: 5);
        }
        [Theory]
        [InlineData(25, 5)]
        [InlineData(0, 0)]
        [InlineData(49, 7)]
        public void SquareRoot_ValidInputs_ReturnsCorrectResult(double input, double expected)
        {
            var result = _calc.SquareRoot(input);
            Assert.Equal(expected, result, precision: 5);
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        public void SquareRoot_NegativeInput_ThrowsException(double input)
        {
            Assert.Throws<ArgumentException>(() => _calc.SquareRoot(input));
        }
    }
}
