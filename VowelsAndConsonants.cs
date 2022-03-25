using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class VowelsAndConsonants
    {
        public void Alphabet()
        {
            Console.WriteLine("\nEnter any alphabet : ");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'|| ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine($"\n{ch} is Vowel");
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine($"\n{ch} is Consonant");
            }
            else
            {
                Console.WriteLine($"\n{ch} is not a Vowel or not a Consonants");
            }

        }
    }
}
