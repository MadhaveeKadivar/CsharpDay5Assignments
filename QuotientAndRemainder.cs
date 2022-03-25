using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class QuotientAndRemainder
    {
        public void FindQR()
        {
            Console.WriteLine("\nEnter Dividend Number :");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Divisor Number :");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int remainder,Quotient;
            remainder = dividend % divisor;
            Quotient = dividend / divisor;

            Console.WriteLine($"Qutient when {dividend} divided by {divisor} is : {Quotient}");
            Console.WriteLine($"Remainder when {dividend} divided by {divisor} is : {remainder}");
        }
    }
}
