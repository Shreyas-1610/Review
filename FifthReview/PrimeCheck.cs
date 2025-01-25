using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthReview
{
    public class PrimeCheck
    {
        [Required(ErrorMessage = "Number is required.")]
        [Range(2, 1000, ErrorMessage = "Please enter a valid integer greater than or equal to 2.")]
        public int Number { get; set; }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
