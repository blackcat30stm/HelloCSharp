using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class GravitationMoon
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter your weight: ");
            int weight = int.Parse(Console.ReadLine());
            double gravityMoon = 0.17;
            double weightMoon = weight * gravityMoon;
            Console.WriteLine(weightMoon);

        }
    }
}
