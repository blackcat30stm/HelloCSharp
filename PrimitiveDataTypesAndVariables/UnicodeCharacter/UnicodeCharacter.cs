using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            int value = 0x2A;
            char symbol = (char)value;
            Console.WriteLine( symbol);
        }
    }
}
