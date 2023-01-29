using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelConsonant
    {
        public static void FindVowelConsonant() 
        {
            Console.WriteLine("Enter a character in small case");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("A character is vowel");
            }
            else 
            {
                Console.WriteLine("A character is consonant");
            }
        }
    }
}
