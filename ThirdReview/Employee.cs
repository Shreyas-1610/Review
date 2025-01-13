using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdReview
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept {  get; set; }
        public int Salary { get; set; }

        public int YearOfJoining { get; set; }

        public List<Employee> getAll()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id = 1, Name= "Shreyas", Dept="IT", Salary = 40, YearOfJoining = 2025},
                new Employee{Id = 2, Name= "ABC", Dept="Sales", Salary = 30, YearOfJoining = 2020},
                new Employee{Id = 3, Name= "LMN", Dept="IT", Salary = 45, YearOfJoining = 2022},
                new Employee{Id = 4, Name= "XYZ", Dept="HR", Salary = 50, YearOfJoining = 2025},
                new Employee{Id = 5, Name= "Eren", Dept="Sales", Salary = 34, YearOfJoining = 2023},
                new Employee{Id = 6, Name= "RST", Dept="HR", Salary = 32, YearOfJoining = 2024},
            };
            return employees;
        }
    }

}
