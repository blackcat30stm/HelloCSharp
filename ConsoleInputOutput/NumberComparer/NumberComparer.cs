using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers pressing \"Enter\" between them : ");
            Console.WriteLine("Greater : " + Math.Max(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                
                

        }
    }
}
