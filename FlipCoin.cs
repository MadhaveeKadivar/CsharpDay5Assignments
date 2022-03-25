using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class FlipCoin
    {
        public void coin()
        {
            int numberOfFlips,heads=0,tails=0;
            Console.WriteLine("\nEnter number of times you want to flip coin : ");
            numberOfFlips = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            for(int i = 1; i <= numberOfFlips; i++)
            {
                double result = random.NextDouble();

                Console.WriteLine($"\n\nCoin filpping for {i} times ......");

                if(result < 0.5)
                {
                    Console.WriteLine("\nCoin flipping Result : Tails");
                    tails += 1;
                }
                else
                {
                    Console.WriteLine("\nCoin flipping Result : Heads");
                    heads += 1;
                }
            }

            double h = (heads/Convert.ToDouble(numberOfFlips))*100;
            double t = (tails/Convert.ToDouble(numberOfFlips))*100;
            Console.WriteLine($"\n\nHeads Percentages after fliping coin {numberOfFlips} times  : {h} % ");
            Console.WriteLine($"\nTails Percentages after fliping coin {numberOfFlips} times  : {t} %");
        }
    }
}
