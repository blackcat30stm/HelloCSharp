using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seconds number :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number :");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number :");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth number :");
            double f = double.Parse(Console.ReadLine());

            if ((a > b) & (a > c) & (a > d) & (a > f))
            {
                Console.WriteLine("The biggest is : {0} .", a);
            }
            else if ((b > a) & (b > c) & (b > d) & (b > f))
            {
                Console.WriteLine("The biggest is : {0} .", b);
            }
            else if ((c > a) & (c > b) & (c > d) & (c > f))
            {
                Console.WriteLine("The biggest is : {0} .", c);
            }
            else if ((d > a) & (d > c) & (d > b) & (d > f))
            {
                Console.WriteLine("The biggest is : {0} .", d);
            }
            else
            {
                Console.WriteLine("The biggest is : {0} .", f);
            }
        }
    }
}
