﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string one = "The \"use\" of quotations causes difficulties.";
            string two = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(one + "\r\n" + two);
        }
    }
}
