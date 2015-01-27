﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

    static void Main()
    {
                    Console.Write("Enter n: ");
            int num = int.Parse(Console.ReadLine());

	for (int i = 0; i < num; i++)
	{
	    Console.WriteLine(Fibonacci(i));
	}


            }
        }
    }
