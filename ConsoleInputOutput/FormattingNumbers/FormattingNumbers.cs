using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the fist number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0,-10}|{1}|{2,10:F2}|{3,-10:F3}|",
                firstNumber.ToString("X"), Convert.ToString(firstNumber, 2).PadLeft(10, '0'),
                secondNumber, thirdNumber);
        }
    }
}
