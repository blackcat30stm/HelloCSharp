using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;
            Console.WriteLine("Enter a:");
             a =double.Parse(Console.ReadLine());
             Console.WriteLine("Enter b:");
              b = double.Parse(Console.ReadLine());
              Console.WriteLine("Enter  h: ");
              h = double.Parse(Console.ReadLine());
            double area = (((a + b) /2 ) * h);
            Console.WriteLine("Area: {0}" ,area);

        }
    }
}
