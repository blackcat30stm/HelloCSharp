using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter five numbers separated by space: ");
            double[] numbers = Console.ReadLine()
                .Split(new char[] {' ' , '\t' },StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => double.Parse(n))
                    .ToArray();
            Console.WriteLine("Sum : {0:F2}" , numbers.Sum());
         
        }
    }
}
