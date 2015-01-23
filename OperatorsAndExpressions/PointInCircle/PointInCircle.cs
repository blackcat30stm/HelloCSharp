using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        const double radius = 2;
        const double xY = 0;
        static void Main(string[] args)
        {
            Console.Write("Enter the coordinates X and Y separated by a space. ");
            double[] coordinates = Console.ReadLine()
            .Trim()
            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(a => Double.Parse(a))
            .ToArray();
            Console.WriteLine("The point is {0} the circle.",
            IsInside(coordinates[0], coordinates[1]) ? "INSIDE" : "OUTSIDE");
        }
        static bool IsInside(double x, double y)
        {
            return (Math.Pow((xY - x), 2) + Math.Pow((xY - y), 2) <= radius * radius);
        }
    }
}
