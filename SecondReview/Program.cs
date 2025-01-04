namespace SecondReview
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of role you want: (full / part)");
            string time = Console.ReadLine();
            Employee emp = new Employee(time);
            emp.checkPresent();
            double wageCalculation = emp.Wage();
            Console.WriteLine($"The total wages for a day is: {wageCalculation}");
            double MonthWage = emp.MonthWage();
            Console.WriteLine($"The monthly wage is :{MonthWage}");

        }
    }

    public class Employee
    {
        public string time;

        public Employee(string time)
        {
            this.time = time;
        }
        public void checkPresent()
        {
            Random random = new Random();
            int output = random.Next(0, 2);
            Console.WriteLine(output);
            if (output == 0) 
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee present");
            }
        }

        public double Wage()
        {
            int hours;
            double rate;
            switch (time) {
                case "full":
                    hours = 8;
                    rate = 20;
                    break;
                case "part":
                    hours = 4;
                    rate = 20;
                    break;
                default:
                    Console.WriteLine("Not a valid employee");
                    return 0;
            }
            return hours * rate;
        }

        public double MonthWage()
        {
            double total = Wage();
            int days = 20;
            return total * days;
            
        }
    }
}
