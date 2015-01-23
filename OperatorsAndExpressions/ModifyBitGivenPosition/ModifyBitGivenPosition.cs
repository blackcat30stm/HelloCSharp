using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBitGivenPosition
{
    class ModifyBitGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Enter bit value: ");
            int value = int.Parse(Console.ReadLine());
            if (((number >> position) & 1) != value) number = ChangeBit(number, position);
            Console.Clear();
            Console.WriteLine("Result: " + number);
        }
        private static int ChangeBit(int number, int position)
        {
            return number ^ (1 << position);
        }
    }
}