using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finding_prime
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number ");
            String readInput = Console.ReadLine();
            int readNumber = Int32.Parse(readInput);

            bool result = IsPrime(readNumber);
            if (result == true)
            {
                Console.WriteLine("this is prime number", result);

            }
            else
            {
                Console.WriteLine("this is not a prime number", result);
            }
            Console.ReadLine();

        }
        public static bool IsPrime(int number)
        {
            if (number < 1)
            {
                return false;

            }
            if (number == 2) { return true; }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;

                }
            }
            return true;
        }
    }
}
