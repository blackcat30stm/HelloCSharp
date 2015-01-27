using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many number you want to enter: ");
            int select = int.Parse(Console.ReadLine());
            if (select < 1)
            {
                Console.WriteLine("There is no numbers to sum.");
                return;
            }
            Console.WriteLine("Enter {0} numbers: ", select);
            double sum = 0;
            for (int i = 0; i < select; i++)
            {
                sum += double.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Sum = {0:F2}", sum);
        }
    }
}
