using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthReview
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string msg) : base(msg) { }
    }
    public class AgeValid
    {
        public static void Check()
        {
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            try
            {
                Validate(age);
                Console.WriteLine("Valid age");
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Validate(int age)
        {
            if(age < 18)
            {
                throw new InvalidAgeException("Age should be above 18");
            }
        }
    }
}
