using System.ComponentModel.DataAnnotations;

namespace FifthReview
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //1
            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());
            //var numberInput = new PrimeCheck { Number = num };
            //var validationContext = new ValidationContext(numberInput);
            //var results = new List<ValidationResult>();

            //bool isValid = Validator.TryValidateObject(numberInput, validationContext, results, true);

            //if (!isValid)
            //{
            //    foreach (var result in results)
            //    {
            //        Console.WriteLine(result.ErrorMessage);
            //    }
            //}
            //else
            //{
            //    bool isPrime = PrimeCheck.IsPrime(num);
            //    Console.WriteLine(isPrime ? "The number is prime." : "The number is not prime.");
            //}

            //2
            //SortWithout.BuiltIn();

            //3
            //StackImpl st = new StackImpl(4);
            //st.Push(10);
            //st.Push(20);
            //st.Push(30);

            //Console.WriteLine($"Top element: {st.Peek()}");
            //Console.WriteLine($"Pop element: {st.Pop()}");

            //Console.WriteLine($"Top element: {st.Peek()}");

            //4
            //AgeValid.Check();

            //6
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var stringpath = @"C:\Users\kshre\source\repos\FifthReview\FifthReview\numbers.txt";
            //File.Create(stringpath);
            Task task1 = Task.Run(() => WriteNumbersToFile(stringpath, list));
            int[] arr = { 10, 20, 30 };
            Task task2 = Task.Run(() => CalculateSum(arr));
            Task task3 = Task.Run(() => SortWithout.BuiltIn());
            await Task.WhenAll(task1,task2,task3);
        }

        static void WriteNumbersToFile(string fileName, List<int> numbers)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (int number in numbers)
                {
                    writer.WriteLine(number);
                }
            }
            Console.WriteLine($"Task :{Task.CurrentId} ");
            Console.WriteLine("Numbers added");
        }

        static void CalculateSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum:{sum}");
            Console.WriteLine($"Task :{Task.CurrentId} ");
        }
    }
}
