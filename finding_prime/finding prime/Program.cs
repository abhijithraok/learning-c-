using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finding_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number ");
           String readInput=Console.ReadLine();
            int readNumber=Int32.Parse(readInput);
            Console.WriteLine(readNumber + 1);
            Console.ReadLine();

        }
    }
}
