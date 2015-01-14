using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            int date = 7;
            int month = 4;
            int year = 1900;
            Console.WriteLine(date + "/" + month + "/" + year);
            int age = today.Year - year;
            ;
            int ageafter = age + 10;
            Console.WriteLine("My current age is: " + age);
            Console.WriteLine("My age Aafter 10 years is: " + ageafter);
        }
    }
}
