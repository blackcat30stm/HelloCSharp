using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBySevenAndFive
{
    class IsDivisible
    {
        static void Main(string[] args)
        {
            bool isDivisible = true;
            Console.Write("Enter your number to check f it can be divided by 7 and 5 at the same time. : ");
            int number = int.Parse(Console.ReadLine());
            isDivisible = (number % 35 == 0);
            if (isDivisible)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


            

        }
    }
}
