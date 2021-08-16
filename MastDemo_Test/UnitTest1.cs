using MastDemo;
using System;
using Xunit;



namespace MastDemo_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd1()
        {
            int num = Program.Add(5, 3);
            Assert.Equal(8, num);
        }

        [Fact]

        public void TestCouponNoCoupon()
        {
            bool coupon = Program.IsCoupon(5.00m);
            Assert.False(coupon);
        }

        [Fact]
        public void TestCouponYesCoupon()
        {
            bool coupon = Program.IsCoupon(15.00m);
            Assert.True(coupon);
        }

        [Fact]
        public void TestCouponTenCoupon()
        {
            bool coupon = Program.IsCoupon(10.00m);
            Assert.True(coupon);
        }
        [Fact]

        public void TestMultiply()
        {
            int num = Program.Multiply(3, 5);
            Assert.Equal(15, num);

        }
    }
}
