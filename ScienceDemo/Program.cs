using System;

namespace ScienceDemo
{
    public class Program
    {

        //rate*time = distance
        //time = distance/rate  km/kmperhour
        //rate = distance/time  km/hour

        static public double TimeUntilTouchdown(double D, double R)
        {
            return D / R;
        }

        static public bool IsFibi(int num)
        {
            // start listing Fib numbers
            //if we find the number were looking for return true, its in the list
            //if we to a number greater then the number were looking for, return false its not in the list.

            if (num == 0 || num == 1)
            {
                return true;
            }

            int prev1 = 1;
            int prev2 = 1;
              // starting at 2 because 0 and 1 are special cases.
            while (true)
            {
                int fib = prev1 + prev2;
                if (num == fib)
                {
                    return true;
                }
                if (fib > num)
                {
                    return false;
                }
                //end of loop 
                prev1 = prev2;
                prev2 = fib;
                //Console.WriteLine(num);


            }
        }
        
        public static int GetNthFib(int lookingfor)
            
        {
            if (lookingfor == 1)
            {
                return 0;
            }
            if (lookingfor == 2)
            {
                return 1;
            }
            int current = 0;   //the current number were testing
            int howmany = 0;   //how many fibonacci found
            lookingfor--;
            while (true)
            {
                if (IsFibi(current))
                {
                    howmany++;
                    if (howmany == lookingfor)
                    {
                        return current;
                    }
                }
                current++;
            }
        }
        static void Main(string[] args)
        {
            //once testing is done, then we can focus on using these functions!
            //once tested we know it works, we can focus on interface, we can treat these functions just like console.writeline();  This is how you build software.
            Console.Write("Which Fibonacci would you like?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetNthFib(num)); 
        }
    }
}
