using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            long n = int.Parse(Console.ReadLine());
            if ((n <= 3)  & (n >= 1 ))
            {
                long z = n * 10;
                Console.WriteLine(z);
            }
            else if ((n <= 6) & (n >= 4))
            {
                long x = n * 100;
                Console.WriteLine(x);
            }
            else if ((n <= 9) & (n >= 7))
            {
                long c = n * 1000;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("invalid score.");
            }
        }
    }
}
