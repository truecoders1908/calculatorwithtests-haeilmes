using System;
using Xunit;

namespace CalculatorTests
{
    public class Tests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 3, 6)]
        [InlineData(5, 4, 9)]
        [InlineData(43, 88, 131)]
        [InlineData(-1, 0, -1)]
        [InlineData(0, 0,0)]
        public void Add(int num1, int num2, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();

            //Act
            int actual = challenger.Add(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 3, 1)]
        [InlineData(5, 1, 4)]
        [InlineData(50, 36, 14)]
        [InlineData(8, 12, -4)]
        [InlineData(0, -3, -3)]
        [InlineData(0, 0, 0)]
        public void Subtract(int num1, int num2, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();

            //Act
            int actual = challenger.Subtract(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(7, 5, 35)]
        [InlineData(9, 9, 81)]
        [InlineData(4, -4, -16)]
        [InlineData(-3, -4, 12)]
        [InlineData(9, 0, 0)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();

            //Act
            int actual = challenger.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(6, 5, 1)]
        [InlineData(33, 3, 11)]
        [InlineData(4, 7, 0)]
        [InlineData(100, -25, -4)]
        [InlineData(0, 3, 0)]

        public void Divide(int num1, int num2, int expected)
        {
            //Arange
            Calculator challenger = new Calculator();

            //Act
            int actual = challenger.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 6)]
        [InlineData(4, 32)]
        [InlineData(13, 6227020800)]
        [InlineData(0, 0)]

        public void Factorial(int num1, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();

            //Act
            int actual = challenger.Factorial(num1);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
