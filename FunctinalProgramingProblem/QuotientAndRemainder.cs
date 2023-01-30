using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctinalProgramingProblem
{
    internal class QuotientAndRemainder
    {
        public static void FindQuotientAndRemainder() 
        {
            Console.WriteLine("Enter The divident");
            int divident=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = divident / divisor;
            Console.WriteLine("The Quotient is {0}", quotient);
            int remainder = divident % divisor;
            Console.WriteLine("The Remainder is {0}", remainder);
        }
    }
}
