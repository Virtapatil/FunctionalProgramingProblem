using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctinalProgramingProblem
{
    internal class PowerOf2
    {
        public static void FindPowerOf2()
        {
            Console.WriteLine("Enter The number");
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n&&n<=31; i++)
            {
                double result = Math.Pow(2,i);
                Console.WriteLine("{0} power {1} : {2}",2,i,result);
            }
        }
    }
}
