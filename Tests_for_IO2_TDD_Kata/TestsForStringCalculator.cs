using System;
using Xunit;
using IO2_TDD_Kata;

namespace Tests_for_IO2_TDD_Kata
{
    public class TestsForStringCalculator
    {
        StringCalculator stringCalculator;

        public TestsForStringCalculator()
        {
            stringCalculator = new StringCalculator();
        }

        [Fact]
        public void NullStringTest()
        {            
            Assert.Equal(0, stringCalculator.Parse(null));
        }

        [Fact]
        public void SingleNumberTest()
        {
            Assert.Equal(5, stringCalculator.Parse("5"));
        }

        [Fact]
        public void TwoNumbersTest()
        {
            Assert.Equal(5, stringCalculator.Parse("2,3"));
        }

        [Fact]
        public void ThreeNumbersTest()
        {
            Assert.Equal(8, stringCalculator.Parse("2,3\n3"));
        }

        [Fact]
        public void NegativeNumberTest()
        {
            Assert.Throws<ArgumentException>(() => stringCalculator.Parse("-4"));
        }

        [Fact]
        public void IgnoreNumberTest()
        {
            Assert.Equal(0, stringCalculator.Parse("1001"));
        }
    }
}
