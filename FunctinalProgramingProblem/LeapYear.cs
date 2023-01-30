using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctinalProgramingProblem
{
    internal class LeapYear
    {
        public static void FindLeapyear()
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            //int year = int.parse(console.ReadLine());
            if ((year % 4 == 0 && year % 100!= 0) || year % 400 == 0)
            {
            Console.WriteLine("year is Leap year:" + year);
            }
            else
            {
            Console.WriteLine("year is not Leap year:" + year);
            }
        }
    }
}
