using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class calculatorTests
    {
        [Theory]
        [InlineData(0, 5, 8, 13)]
        [InlineData(7, 3, 9, 19)]
        [InlineData(1, 8, 2, 11)]
        [InlineData(9, 7, 4, 20)]
        public void Add_Test(int num1, int num2, int num3, int expected)
        {

            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0, 5, -5)]
        [InlineData(3, 9, -6)]
        [InlineData(8, 2, 6)]
        [InlineData(7, 4, 3)]
        public void Subtract_Test(int num1, int num2, int expected)
        {

            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Subtract(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(3, 9, 27)]
        [InlineData(8, 2, 16)]
        [InlineData(7, 4, 28)]
        public void Multiply_Test(int num1, int num2, int expected)
        {

            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);




        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(9, 3, 3)]
        [InlineData(8, 2, 4)]
        [InlineData(16, 4, 4)]
        public void divide_Test(int num1, int num2, int expected)
        {

            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
