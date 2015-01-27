﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
Console.WriteLine(@"
Plese choose:
I -> integer
D -> double
S -> string");
char choise = Console.ReadLine().Trim().ToUpper()[0];
Console.Clear();
Console.WriteLine(GetResult(choise));
}
private static string GetResult(char choise)
{
switch (choise)
{
case 'I':
Console.Write("Enter a number: ");
int inputInt = int.Parse(Console.ReadLine());
return (inputInt + 1).ToString();
case 'D':
Console.Write("Enter a number: ");
double inputDouble = double.Parse(Console.ReadLine());
return (inputDouble + 1).ToString();
case 'S':
Console.Write("Enter a string: ");
string inputString = Console.ReadLine();
return (inputString + "*");
default:
return "Invalid command!";
}
}
}
}
