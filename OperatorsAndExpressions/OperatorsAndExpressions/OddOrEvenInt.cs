using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class OddOrEvenInt
    {
        static void Main(string[] args)
        {
         
			{
                Console.WriteLine("Enter a number to chek is it even or odd: ");
                int num  = int.Parse(Console.ReadLine());
                Console.WriteLine(num % 2 == 1 ? "The number is odd" : " The number is even");
			 
			}
        }
    }
}
