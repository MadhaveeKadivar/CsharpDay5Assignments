using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class LargestNumber
    {
        public void Largest()
        {
            int first, second, third,result;
            Console.WriteLine("\nEnter the first number :");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number :");
            third = Convert.ToInt32(Console.ReadLine());

            //Using Array method
            //int[] numbers = { first, second, third };
            //result = numbers.Max();

            if (first > second && first > third)
            {
                result = first;
            }
            else if (second > first && second > third)
            {
                result = second;
            }
            else
            {
                result= third;
            }

            Console.WriteLine($"\nThe largest number is : {result}");
        }
    }
}
