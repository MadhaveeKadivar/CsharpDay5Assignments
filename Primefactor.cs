using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class Primefactor
    {
        public void FindPrimeFactor()
        {
            Console.WriteLine("\nEnter any number you want to prime factorize : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAll prime factors of the $n are : ");
            for (int i = 2; 1<n; i++)
            {
                while (n%i==0)
                {
                    Console.Write($"\n{i} ");
                    n=n/i;
                }
            }
        }
    }
}
