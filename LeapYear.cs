using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class LeapYear
    {
        public void FindLeapYear()
        {
            int year;
            while (true)
            {
                Console.WriteLine("\nEnter any 4 digit Year : ");
                year = Convert.ToInt32(Console.ReadLine());

                if (year > 1000  && year < 9999)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter only 4 digit Year");
                }
            }
            if ((year%4)==0 && (year%100)!=0 || (year%400)==0)
            {
                Console.WriteLine($"{year} is a Leap Year");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year");
            }
        }
    }
}
