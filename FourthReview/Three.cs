using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FourthReview
{
    internal class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    internal class Three
    {
        public static void AddCsv()
        {
            string path = @"C:\Users\kshre\source\repos\FourthReview\FourthReview\example.csv";
            //File.Create(path);
            Console.WriteLine("Created");
            var records = new List<User>
            {
                new User{Age = 21, Name = "Shreyas", Email = "shreyas@gmail.com"},
                new User{Age = 18, Name = "DEF", Email = "abc@gmail..com"},
                new User{Age = 33, Name = "BCC", Email = "def.com"},
                new User{Age = 16, Name = "A", Email = "ghi@gmail.com"},
                new User{Age = 17, Name = "ABC", Email = "klm@gmail.com"}
            };

            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
            Console.WriteLine("DATA WRITTEN");
        }

        public static void ReadCsv()
        {
            string path = @"C:\Users\kshre\source\repos\FourthReview\FourthReview\example.csv";
            using (var reader = new StreamReader(path))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var dataCsv = csvReader.GetRecords<User>();
                foreach (var data in dataCsv)
                {
                    Console.WriteLine($"Age:{data.Age}, Name:{data.Name}, Email:{data.Email}");
                }
            }
        }

        public static void FilterCsv()
        {
            string inputFilePath = @"C:\Users\kshre\source\repos\FourthReview\FourthReview\example.csv";
            string outputFilePath = @"C:\Users\kshre\source\repos\FourthReview\FourthReview\filtered.csv";
            int minAge = 18;

            using (var reader = new StreamReader(inputFilePath))
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    string email = @"^[a-zA-Z0-9._]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}";
                    Regex emailRegex = new Regex(email);

                    var filteredUsers = new List<User>();
                    var records = csvReader.GetRecords<User>();
                    foreach (var user in records)
                    {
                        if (emailRegex.IsMatch(user.Email) && user.Age > minAge)
                        {
                            filteredUsers.Add(user);
                        }
                    }

                    using (var writer = new StreamWriter(outputFilePath))
                        using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            csvWriter.WriteRecords(filteredUsers);
                        }
                    Console.WriteLine("Data written in filtered.csv");
                }
        }
    }
}
