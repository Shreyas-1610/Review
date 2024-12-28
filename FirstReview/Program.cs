namespace FirstReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a string: ");
            //string str = Console.ReadLine();
            //FirstVowel.Alphabet(str);

            //Console.WriteLine("Enter a string: ");
            //string str = Console.ReadLine();
            //RemoveVowel.Review2(str);

            //Console.WriteLine("Enter your birthdate: ");
            //DateOnly today = DateOnly.Parse(Console.ReadLine());
            //int age = BirthDate.CalculateAge(today);
            //Console.WriteLine(age);

            //Console.WriteLine("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());
            //Review4.sum(n);

            Shape shape = new Shape();
            double square = shape.area(12);
            double rect = shape.area(10, 12);
            double circle = Math.Round(shape.area(12.45), 2);
            Console.WriteLine($"Area of square: {square}.\n Area of Rectangle: {rect} \n Area of Circle: {circle}");
        }
    }

    public class Shape
    {
        public double area(int n)
        {
            return n * n;
        }

        public double area(int l, int r)
        {
            return l * r;
        }

        public double area(double r)
        {
            return Math.PI * (r * r);
        }
    }
}
