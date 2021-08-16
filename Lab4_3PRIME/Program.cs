using System;

namespace Lab4_3PRIME
{
    public class Program
    {
        static bool Continue()
        {
            while (true)
            {
                Console.Write("Do you want to find another prime? ");
                string response = Console.ReadLine();
                response.ToLower();
                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no"){
                    return false;
                }
                else
                {
                    Console.Write("I didn't understand, please enter (y)es or (n)o! ");
                }
            }
        }
        public static bool IsPrime(int num)
        {
            bool CalcPrime(int value)
            {
                var possibleFactors = Math.Sqrt(num);
                for (var factor = 2; factor <= possibleFactors; factor++)
                {
                    if (value % factor == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return num > 1 && CalcPrime(num);
        }
        public static int GetPrime(int amPrime)
        {
            int current=0;
            int counter=0;
            while (true)
            {
                if (IsPrime(current))
                {
                    counter++;
                    if (counter == amPrime)
                    {
                        return current;
                    }
                }
                current++;
            }
        }

        public static void MainProggy()
        {
            Console.WriteLine("Hello User!\n");
            do
            {
                Console.Write("Which Prime Number in order of Primes do you want to calculate? ");
                int calc;
                bool isNum = int.TryParse(Console.ReadLine(), out calc);
                if (isNum)
                {
                    if (calc < 1)
                    {
                        Console.WriteLine("We can't calculate a prime with a proper slot! please enter 1 through 10000!\n");
                    }
                    else if (calc > 10000)
                    {
                        Console.WriteLine("Please choose a lower number, a number this large is gonna take too long to calculate! Your computer will thank you!\n");
                    }
                    else
                    {
                        Console.WriteLine($"The Prime number in the order of primes at slot {calc} is {GetPrime(calc)}!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Thats not a number!\n");
                }
            }
            while (Continue());
        }
        static void Main(string[] args)
        {
            MainProggy();
        }
    }
}
