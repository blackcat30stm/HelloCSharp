using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchangeAdvanced
{
    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            long number = long.Parse(Console.ReadLine());
            Console.Write("Enter position P: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter position q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter step k: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = p, h = q, d = k; (i <= 32 && h <= 32) && d > 0; i++, h++, d--)
            {
                if (((number >> i) & 1) != ((number >> h) & 1))
                {
                    number = changeBits(number, i, h);
                }
            }
            Console.WriteLine("Result: " + number);
        }
        private static long changeBits(long number, int positionOne, int positionTwo)
        {
            number ^= (1 << positionOne);
            return number ^ (1 << positionTwo);
        }
    }
}
