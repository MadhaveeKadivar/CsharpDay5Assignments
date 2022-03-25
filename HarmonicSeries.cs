using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class HarmonicSeries
    {
        public void Harmonic()
        {
            Console.WriteLine("\nEnter number you want find Harmonic Value upto this : ");
            int no = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int i = 1; i <= no; i++)
            {
                
                result += (1/(Convert.ToDouble(i)));
                if (i == no)
                {
                    Console.Write($"1/{i} = ");
                }
                else
                {
                    Console.Write($"1/{i} + ");
                }
            }
            Console.Write(result);
        }
    }
}
