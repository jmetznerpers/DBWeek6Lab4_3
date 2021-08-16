using System;
using Xunit;
using ScienceDemo;

namespace ScienceDemoTest
{
    public class UnitTest1
    {
        [Theory]      //[Fact]  fact is one test, theory is multiple
        //Distance     Rate      Expected
        //100.0    2.0            50.0
        //80.0     40.0             2.0
        //20.0     4.0             5.0
        //we want to do all 3 tests with this one function
        [InlineData(100.0, 2.0, 50.0)]
        [InlineData(80.0, 40.0, 2.0)]
        [InlineData(20.0, 4.0, 5.0)]
        public void TestTouchdownTime(double dist, double rate, double expected) //shows how the inline date is organized and what format its in.
        {
            //double time = Program.TimeUntilTouchdown(100.0, 3.0);
            // Assert.Equal(Math.Abs(100.0 / 3.0), time);

            double time = Program.TimeUntilTouchdown(dist, rate);
            Assert.Equal(expected, time);  //expected always goes first!   can also put program.timeuntiltouchdown(dist, rate)); under actual   .equal tests that expected and actual are equal

        }

        /*  n     expected
         *  0   true    
         *  2   true
         *  4   false
         *  8   true
         *  10  false
         *  21  true
         *  25  false
         * 
         * 
         */
        [Theory]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(4, false)]
        [InlineData(8, true)]
        [InlineData(10, false)]
        [InlineData(21, true)]
        [InlineData(25, false)]
        public void TestIsFibi(int num, bool expected)
        {
            bool result = Program.IsFibi(num);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        [InlineData(6, 5)]
        [InlineData(9, 21)]
        [InlineData(13, 144)]

        public void TestNthFibi(int num, int expected)
        {
            int actual = Program.GetNthFib(num);
            Assert.Equal(expected, actual);
        }
    }
}
