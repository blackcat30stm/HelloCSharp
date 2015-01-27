using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a :");
            double c = double.Parse(Console.ReadLine());

            if ( ((a* b )* c ) > 0)
            {
                Console.WriteLine("+");
            }
            else if (((a * b) * c) < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
             }
        }
    }

