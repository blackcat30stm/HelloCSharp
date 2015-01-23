using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideCircleOutsideRectangle
{
    class PiontInCircleOutRectangle
    {
        const double radius = 1.5;
        const double xY = 1;
        static void Main(string[] args)
        {
            Console.Write("Enter the coordinates X and Y separated by a space. ");
            double[] coords = Console.ReadLine()
            .Trim()
            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Double.Parse(x))
            .ToArray();
            Console.WriteLine("inside K & outside of R: {0}", IsInsideCircle(coords[0], coords[1]) && !IsOutsideRectangle(coords[0], coords[1]));
        }
        static bool IsInsideCircle(double x, double y)
        {
            return (Math.Pow((xY - x), 2) + Math.Pow((xY - y), 2) <= radius * radius);
        }
        static bool IsOutsideRectangle(double X, double Y)
        {
            
            double x1 = -1, x2 = 5, y1 = 1, y2 = 5;
            return !(X >= x1 && X <= x2 && Y >= y1 && Y <= y2);

        }
    }
}