﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a  index p:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("bit p: " + ((n >> p) & 1));
            
        }
    }
}
