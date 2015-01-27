using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                SwapVar(ref firstNum, ref secondNum);
            }
            Console.WriteLine("{0} {1}", firstNum, secondNum);
        }
        private static void SwapVar(ref double firstNum, ref double secondNum)
        {
            double x = firstNum;
            firstNum = secondNum;
            secondNum = x;
        }
    }
}
