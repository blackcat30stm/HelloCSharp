using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string variableOne = "Hello";
            string variableTwo = "World";
            object variable = variableOne + " " + variableTwo;
            string variableThree = (string)variable;
            Console.WriteLine(variableThree);




        }
    }
}
