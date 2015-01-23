using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 3, j = 24; i < 6; i++, j++)
            {
                if (((number >> i) & 1) != ((number >> j) & 1))
                {
                    number = ChangeBits(number, i, j);
                }
            }
            Console.WriteLine("Result: " + number);
        }
        private static int ChangeBits(int number, int firstposition, int secondPosition)
        {
            number ^= (1 << firstposition);
            return number ^ (1 << secondPosition);
        }
    }

}