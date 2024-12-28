using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReview
{
    internal class BirthDate
    {
        public static int CalculateAge(DateOnly date)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - date.Year;

            return age;
        }
    }
}
