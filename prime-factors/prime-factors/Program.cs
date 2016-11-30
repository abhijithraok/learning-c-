using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_factors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your integer: ");
            int number = Int32.Parse(Console.ReadLine());
            Dictionary<int, int> result = Factor(number);


            Console.ReadLine();



        }

        public static Dictionary<int, int> Factor(int number)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();


            for (int b = 2; number > 1; b++)
                if (number % b == 0)
                {
                    int FactorTimes = 0;
                    while (number % b == 0)
                    {
                        number /= b;
                        FactorTimes++;
                    }

                    result.Add(b, FactorTimes);
                    Console.WriteLine("{0} is a prime factor {1} times!", b, FactorTimes);

                }
            return result;


        }

    }

}
