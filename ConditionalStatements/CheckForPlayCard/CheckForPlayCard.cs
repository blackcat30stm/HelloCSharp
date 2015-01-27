using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPlayCard
{
    class CheckForPlayCard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sign to check it is a valid card sign: ");
            string s = string.Format(Console.ReadLine());
            if ((s == "2") | (s == "3") | (s == "4") | (s == "5") | (s == "6") | (s == "7") | (s == "8") | (s == "9") | (s == "10") | (s == "J") | (s == "Q") | (s == "K") | (s == "A") )
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
