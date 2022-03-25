using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class SwapTwoNumbers
    {
        public void Swap()
        {
            int first, second;
            Console.WriteLine("\nEnter first number : ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBefore Swapping ");

            Console.WriteLine("\nFirst number = " + first);
            Console.WriteLine("Second number = " + second);
            first += second;
            second = first - second;
            first -= second;

            Console.WriteLine("\n\nAfter Swapped ");

            Console.WriteLine("\nFirst number = " + first);
            Console.WriteLine("Second number = " + second);
        }
    }
}
