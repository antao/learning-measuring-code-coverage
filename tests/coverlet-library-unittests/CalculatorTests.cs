using System;
using coverlet_library_sample;
using Xunit;

namespace coverlet_library_unittests
{
    public class CalculatorTests
    {
        private readonly Calculator _target;

        public CalculatorTests()
        {
            _target = new Calculator();
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(10, 1, 10)]
        [InlineData(100, 20, 5)]
        public void Division(decimal x, decimal y, decimal expected)
        {
            // Arrange
            // Act
            var actual = _target.Division(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Division_Should_Throw_DivideByZeroException_When_Dividing_By_Zero()
        {
            Assert.Throws<DivideByZeroException>(() => _target.Division(42, 0));
        }

        [Theory]
        [InlineData(41, 1, 42)]
        [InlineData(0, 42, 42)]
        [InlineData(42, 0, 42)]
        public void Addition(decimal x, decimal y, decimal expected)
        {
            // Arrange
            // Act
            var actual = _target.Addition(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(43, 1, 42)]
        [InlineData(0, 42, -42)]
        [InlineData(42, 0, 42)]
        public void Subtraction(decimal x, decimal y, decimal expected)
        {
            // Arrange
            // Act
            var actual = _target.Subraction(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
