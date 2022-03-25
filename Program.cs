using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 5 Assignments Problems");
            Console.WriteLine("\nProblem 1 : Flip Coin With Percentage\nProblem 2 : Leap Year\nProblem 3 : Power of 2 Table");
            Console.WriteLine("Problem 4 : Harmonic Series\nProblem 5 : Prime Factors of Number");
            Console.WriteLine("Problem 6 : Quotient and Remainder\nProblem 7 : Swap two Numbers\nProblem 8 : Even and Odd");
            Console.WriteLine("Problem 9 : Vowels and Consonants\nProblem 10 : Largest among three numbers\n");

            Console.WriteLine("Enter your choice : ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.coin();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.FindLeapYear();
                    break;
                case 3:
                    Power power = new Power();
                    power.Findpower();
                    break;
                case 4:
                    HarmonicSeries harmonicSeries = new HarmonicSeries();
                    harmonicSeries.Harmonic();
                    break;
                case 5:
                    Primefactor primefactor = new Primefactor();
                    primefactor.FindPrimeFactor();
                    break;
                case 6:
                    QuotientAndRemainder qr = new QuotientAndRemainder();
                    qr.FindQR();
                    break;
                case 7:
                    SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                    swapTwoNumbers.Swap();
                    break;
                case 8:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.CheckEvenOdd();
                    break;
                case 9:
                    VowelsAndConsonants vowelsAndConsonants = new VowelsAndConsonants();
                    vowelsAndConsonants.Alphabet();
                    break;
                case 10:
                    LargestNumber largestNumber = new LargestNumber();
                    largestNumber.Largest();
                    break;

            }

            Console.ReadLine();
        }
    }
}
