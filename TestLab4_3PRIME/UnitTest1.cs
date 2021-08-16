using System;
using Xunit;
using Lab4_3PRIME;

namespace TestLab4_3PRIME
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        [InlineData(11, true)]
        public void TestIsPrime(int num, bool expected)
        {
            bool result = Program.IsPrime(num);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1,2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]
        [InlineData(8, 19)]
        [InlineData(9, 23)]
        [InlineData(10, 29)]
        [InlineData(11, 31)]
        [InlineData(12, 37)]
        [InlineData(10000, 104729)]
        public void TestGetPrime(int num, int expected)
        {
            int isPrime = Program.GetPrime(num);
            Assert.Equal(expected, isPrime);
        }
    }
}
