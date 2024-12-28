using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReview
{
    internal class RemoveVowel
    {
        public static void Review2(string str)
        {
            StringBuilder sb = new StringBuilder();
            string final = str.ToLower();
            foreach (char c in final) { 
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    continue;
                }
                sb.Append(c);
            }
            string ans = sb.ToString();
            Console.WriteLine($"String without vowels is: {ans}");
        }
    }
}
