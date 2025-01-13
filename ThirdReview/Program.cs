namespace ThirdReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Product product = new Product();
            var emp = employee.getAll();
            var proc = product.getProducts();

            //after date
            var firstQuery = emp.Where(e => e.YearOfJoining > 2023).ToList();
            //foreach (var e in firstQuery)
            //{
            //    Console.WriteLine($"ID:{e.Id} Name:{e.Name} Dept:{e.Dept} Salary:{e.Salary} DateofJoin:{e.YearOfJoining}");
            //}
            //average of each dept
            var secondQuery = emp.GroupBy(e => e.Dept).Select(grp => new
            {
                dept = grp.Key,
                Avg = grp.Average(e => e.Salary)
            }).ToList();

            //foreach (var avg in secondQuery)
            //{
            //    Console.WriteLine($"{avg.dept}: {avg.Avg}");
            //}

            //group by emp name
            var thirdQuery = emp.GroupBy(e => e.Dept).Select(em => new
            {
                dept = em.Key,
                emp = em.Select(e => e.Name).ToList()
            }).ToList();
            //foreach (var third in thirdQuery)
            //{
            //    Console.WriteLine($"{third.dept}: {string.Join(",", third.emp)}");
            //}

            var fourthQuery = emp.OrderByDescending(e => e.Salary).Take(3).ToList();
            //foreach (var item in fourthQuery)
            //{
            //    Console.WriteLine($"{item.Name}: {item.Salary}");
            //}

            //stock less than 10
            var sFirst = proc.Where(p => p.Quantity < 10).ToList();
            //foreach (var s in sFirst)
            //{
            //    Console.WriteLine($"{s.PId}: {s.Name}");
            //}

            //calculate of specific
            var specific = proc.Where(p => p.Category == "Elec").Sum(p => p.Price * p.Quantity);
            //Console.WriteLine($"Sum of Electronics is {specific}");

            //cheapest in each
            var cheap = proc.GroupBy(p => p.Category).Select(e => e.OrderBy(p => p.Price).First()).ToList();
            foreach (var c in cheap)
            {
                Console.WriteLine($"Name:{c.Name} Category:{c.Category} Price:{c.Price}");
            }
        }
    }
}
