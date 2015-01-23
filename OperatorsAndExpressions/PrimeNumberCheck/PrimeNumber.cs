using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int numOne;
            Console.WriteLine("Enter a number");
            numOne = Convert.ToInt32(Console.ReadLine());
            if (numOne == 0 || numOne == 1)
            {
                Console.WriteLine(numOne + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= numOne / 2; a++)
                {
                    if (numOne % a == 0)
                    {
                        Console.WriteLine(numOne + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(numOne + " is a prime number");
                Console.ReadLine();
            }
        }
    }
}