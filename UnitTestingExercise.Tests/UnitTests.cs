using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(4, 5, 6, 15)]
        [InlineData(300, 300, 200, 800)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();
            //Act
            var actual = calculator.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData( 100, 50, 50)]
        [InlineData(1500, 37, 1463)]
        [InlineData(-300,-300,0)]
        [InlineData(2,1,1)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var subt = new UnitTestMethods();

            //Act
            var actual = subt.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(-100,13,-1300)]
        [InlineData(-3,-44,132)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multi = new UnitTestMethods();
            //Act
            var actual = multi.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(33,3,11)]
        [InlineData(1400,7,200)]
        [InlineData(-14,2,-7)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divi = new UnitTestMethods();

            //Act
            var actual = divi.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
