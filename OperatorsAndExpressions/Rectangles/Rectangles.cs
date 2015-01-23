using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {

            Console.Write("Enter width:");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height:");
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            Console.WriteLine("Perimeter = {0:F2} \n Area = {1:F2}", perimeter, area); 



        }
    }
}
