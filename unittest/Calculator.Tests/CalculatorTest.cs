using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyFourWithThreeIsTwelve()
        {
            // Arrange
            int a = 4;
            int b = 3;
            int expected = 12;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideSixByTwoIsThree()
        {
            // Given
            int a = 6;
            int b = 2;
            double expected = 3.0;
            Calculator calculator = new Calculator();

            // When
            double actual = calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionByZeroCausesException()
        {
            // Arrange
            int a = 7;
            int b = 0;
            Calculator calculator = new Calculator();

            // Act/Assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(a, b));
        }
    }
}
