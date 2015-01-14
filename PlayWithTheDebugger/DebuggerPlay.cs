using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithTheDebugger
{
    class DebuggerPlay
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 1001;
            for (int i = 1; i < 1001; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
