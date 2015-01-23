using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIsSeven
{
    class ThirdIsSeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check, if the third digit is seven: ");
                long num = long.Parse(Console.ReadLine());
                bool check = ((num / 100) % 10 == 7);
                Console.WriteLine("Third digit is 7: {0}", check);
    
        }
    }
}