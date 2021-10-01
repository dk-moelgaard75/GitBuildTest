using System;
using Xunit;
using sl_test_2021_uge4;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int a = 1;
            int b = 2;
            int expected = 3;

            //Act
            Calculator calc = new Calculator();
            int result = calc.add(a, b);
            //assert
            Assert.Equal(expected, result);
        }
        public void Test2()
        {
            //Arrange
            int a = 20;
            int b = 10;
            int expected = 10;

            //Act
            Calculator calc = new Calculator();
            int result = calc.sub(a, b);

            //Assert
            Assert.Equal(expected, result);
        }
        public void Test3()
        {
            //Arrange
            int a = 10;
            int b = 10;
            int expected = 100;

            //Act
            Calculator calc = new Calculator();
            int result = calc.multi(a, b);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
