using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            float a = 7.34f;
            float b = 8.21f;
            float c = 7.123456789f;
            float d = 7.12345678901f;
            bool compareFirst = (a == b);
            Console.WriteLine(compareFirst);
            bool compareSecond = (c == d);
            Console.WriteLine(compareSecond);
        }
    }
}
