﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a={0} ",a);
            Console.WriteLine("b= {0}",b);
            int exchange = a;
            a = b;
            b = exchange;
            Console.WriteLine("a={0} ", a);
            Console.WriteLine("b= {0}",b);


            

        }
    }
}
