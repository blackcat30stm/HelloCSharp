using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFirstAndLastName
{
    class PrintFirstAndLastName
    {
        static void Main(string[] args)
        {
            string firstName = "Johnny";
            string lastName = "Depp";
            string fullName = firstName + "\r\n" + lastName;
            Console.WriteLine(fullName);
        }
    }
}
