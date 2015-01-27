using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterArea
{
    class CirclePerimeterArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            double r = double.Parse(Console.ReadLine());
            double perimeter =3.14 * 2 * r ;
            double area =   3.14 * (r * r );
            Console.WriteLine("Perimeter: {0}\n\r Area: {1}" , perimeter , area);

        }
    }
}
