using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class Power
    {
        public void Findpower()
        {
            Console.WriteLine("Enter number you want to Find power of 2 : ");
            int no = Convert.ToInt32(Console.ReadLine());
            if (no>=0 && no < 31)
            {
                int result = 1;
                for (int i = 1; i <= no; i++)
                {                    
                    result *= 2;
                    Console.WriteLine($"\n2 ^ {i} = {result}");
                }
            }
           
        }
    }
}
