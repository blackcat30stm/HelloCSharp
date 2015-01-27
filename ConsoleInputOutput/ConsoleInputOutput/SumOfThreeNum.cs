using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class SumOfThreeNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter a: ");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine( "Enter b: ");
            long b = long.Parse(Console.ReadLine());
            Console.WriteLine( "Enter c: ");
            long c = long.Parse(Console.ReadLine());
            long sum = (a + b + c);
            Console.WriteLine("sum of {0} + {1} + {2} = {3}" , a , b , c , sum);

        }
    }
}
