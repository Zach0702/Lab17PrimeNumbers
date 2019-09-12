using GrandCircusLab17;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestPrimeNumber()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(2);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber1()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(3);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber2()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(5);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber3()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(7);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber4()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(7);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber5()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(11);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestPrimeNumber6()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(13);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber7()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(17);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber8()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(19);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber9()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(23);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber10()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(29);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber11()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(31);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber12()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(37);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber13()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(41);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber14()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(43);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TestPrimeNumber15()
        {
            //Arrange
            var sut = new PrimeNumber();

            //Act
            var result = sut.isPrimeNumber(47);

            //Assert
            Assert.True(result);
        }
    }
}
