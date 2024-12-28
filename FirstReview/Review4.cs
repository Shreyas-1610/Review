using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReview
{
    internal class Review4
    {
        public static void sum(int n)
        {
            int even =0 , odd =0 ;
            while (n > 0)
            {
                int temp = n % 10;
                if (temp % 2 == 0)
                {
                    even += temp;
                }
                else
                {
                    odd += temp;
                }
                n /= 10;
            }
            Console.WriteLine($"Even sum: {even}");
            Console.WriteLine($"odd sum: {odd}");

        }
    }
}
