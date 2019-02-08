using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Mul_WorksWithTwoPositiveIntegers()
        {
            var expected = 15;
            var a = 5;
            var b = 3;
            var actual = Mul(5, 3);
            Assert.Equal(expected, actual);
        }

        int Mul(int x, int y)
        {
            return x * y;
        }

         bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(10)]
        public void IsEven_WorksWithManyInputs(int value)
        {
            Assert.True(IsEven(value));
        }
    }
}
