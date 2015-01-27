using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfThreeNumbers
{
    class BiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c :");
            double c = double.Parse(Console.ReadLine());
            if ((a > b) & (a > c))   
            {
                Console.WriteLine("The biggest is : {0} ." , a);
            }
            else if ((b > c) & (b > a))   
            {
                Console.WriteLine("The biggest is : {0} ." , b);
            }
            else
            {
                Console.WriteLine("The biggest is : {0} .", c);
            }
        }
    }
}
