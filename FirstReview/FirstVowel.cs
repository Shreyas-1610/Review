using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReview
{
    internal class FirstVowel
    {
        public static void Alphabet(string str)
        {
            string ans = str.ToLower();
            int v = 0, cons = 0;
            foreach (char c in ans)
            {
                if(c=='a'|| c=='e'|| c == 'i' || c == 'o' || c == 'u')
                {
                    v++;
                }
                else
                {
                    cons++;
                }
            }
            Console.WriteLine($"Vowel: {v}");
            Console.WriteLine($"Consonant: {cons}");
        }
    }
}
