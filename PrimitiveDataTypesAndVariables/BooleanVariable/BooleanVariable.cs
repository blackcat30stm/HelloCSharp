using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            var female = true;
            var  male = false;
            bool isFemale = (female || male) ; 
            Console.WriteLine("is female: {0}", isFemale);
        }
    }
}
