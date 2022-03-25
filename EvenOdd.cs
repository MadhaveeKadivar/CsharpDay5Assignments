using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class EvenOdd
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("\nEnter any Number : ");
            int no = Convert.ToInt32(Console.ReadLine());
            if(no%2==0)
            {
                Console.WriteLine($"\n{no} is an Even Number");
            }
            else
            {
                Console.WriteLine($"\n{no} is an Odd Number");
            }
        }

    }
}
