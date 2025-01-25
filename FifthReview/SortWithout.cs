using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthReview
{
    public class SortWithout
    {
        public static void BuiltIn()
        {
            List<string> list = new List<string>() { "Mango", "Apple", "Banana", "Cherry" };
            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (string.Compare(list[i], list[i + 1]) > 0)
                    {
                        string temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swap = true;

                    }
                }
            } while (swap);
            Console.WriteLine("Sorted names: ");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"Task :{Task.CurrentId} ");
        }
    }
}
