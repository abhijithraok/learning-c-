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
           String readInput=Console.ReadLine();
            int readNumber=Int32.Parse(readInput);
           Console.WriteLine(readNumber + 1);
            Console.ReadLine();

        }
        public static bool IsPrime(int number)
        {
            if (number< 1)
            {
                return false;

            }
            if (number == 2) { return true; }
            for(int i = 3; i < number; i++)
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
