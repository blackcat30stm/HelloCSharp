using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByGivenNumber
{
    class NumbersDivByGivenNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another posotove number: ");
            int end = int.Parse(Console.ReadLine());
            if (start > end)
            {
                start ^= end;
                end ^= start;
                start ^= end;
            }
            int x = 0;
            for (int n = start; n <= end; n++)
            {
                if (n % 5 == 0)
                    ++x;
            }
            Console.WriteLine("Between {0} and {1} ,there is {2} numbers that can be divided by 5 :", start,end,x);

            }
        }
    }

