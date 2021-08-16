using System;

namespace MastDemo
{
    public class Program
    {
        public static bool IsCoupon(decimal spent)
        {
            // if they spend $10 or more they get a $3 off coupon
            if (spent >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            //int num = Add(5,3);
            //Console.WriteLine(num);  //expect 8   simplest version of testing
            System.Console.WriteLine("Hello!");  //fully qualified statement if not using the using modifier above.
        }
    }
}
