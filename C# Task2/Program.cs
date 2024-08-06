using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task2
{
    internal class Program
    {
        public delegate void Calculate(double x, double y);

        static void Main(string[] args)
        {
            #region Task 1

            //ArrayStack<int> stack = new ArrayStack<int>(5);
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //Console.WriteLine(stack.Pop()); // Output: 3
            //Console.WriteLine(stack.Pop()); // Output: 2
            #endregion

            #region Student class
            //Student[] student = new Student[5];

            //student[0] = new Student(4, "Ali");
            //student[1] = new Student(5, "Ahmed");
            //student[2] = new Student(3, "Sara");
            //student[3] = new Student(1, "Sana");
            //student[4] = new Student(2, "Soha");

            //Console.WriteLine("Unsorted Students: ");

            //foreach (var students in student)
            //{
            //    Console.WriteLine($"Id: {students.Id}, Name: {students.Name}");
            //}
            //Array.Sort(student);
            //Console.WriteLine("\nSorted Students: ");
            //foreach (var students in student)
            //{
            //    Console.WriteLine($"Id: {students.Id}, Name: {students.Name}");
            //}

            //try
            //{
            //    Array.Resize(ref student, 6);
            //    student[5] = new Student(6, "sayed");

            //    Console.WriteLine("\nAfter Resize: ");
            //    foreach (var students in student)
            //    {
            //        Console.WriteLine($"Id: {students.Id}, Name: {students.Name}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region GList
            //GList<int> intlist = new GList<int>();
            //intlist.Add(1);
            //intlist.Add(2);
            //intlist.Add(3);

            //Console.WriteLine("\nDisplaying List: ");
            //intlist.Display();

            //GList<string> str = new GList<string>();
            //str.Add("ahmed");
            //str.Add("ali");
            //str.Add("sara");

            //Console.WriteLine("\nDisplaying List: ");
            //str.Display();


            #endregion

            #region Employee class
            //List<Employee> employees = new List<Employee>
            //{
            //    new Employee(1, "Ahmed", 9000, 'F', 6),
            //    new Employee(2, "Yasser", 12000, 'M', 4),
            //    new Employee(3, "Adham", 8000, 'M', 3),
            //    new Employee(4, "Nada", 11000, 'M', 7),
            //    new Employee(5, "ali", 9500, 'F', 10)
            //};
            //List<Employee> promotedEmployees = employees.FindAll(Employee.PromotionCriteria);
            //Console.WriteLine("Promoted Employees: ");
            //foreach (Employee employee in promotedEmployees)
            //{
            //    Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, " +
            //        $"Salary: {employee.Salary}, Gender: {employee.Gender}, Experience: {employee.Experience}");
            //}

            // Multicast delegate for calculation functions

            //Calculate calc = sum;
            //calc += sub;
            //calc += multiply;
            //calc += divide;

            //calc(10, 5);

            #endregion

            #region Company
            Products p1 = new Products(1, "gebnaa");
            Products p2 = new Products(2, "lanshoon");

            // Create suppliers
            Suppliers s1 = new Suppliers(1, "Ahmed");
            Suppliers s2 = new Suppliers(2, "Mohamed");

            Company company = new Company(1, "Tech Company");
            company.stock += s1.NotifyLowStock;

            company.pay(p1, 10);
            company.pay(p2, 20);

            company.sell(p1, 6);
            company.sell(p2, 16);
            #endregion
            Console.ReadKey();
        }
        //public static void sum(double x, double y)
        //{
        //    Console.WriteLine ($"Sum: {x + y}");
        //}

        //public static void sub(double x, double y)
        //{
        //    Console.WriteLine($"sub: {x - y}");
        //}
        //public static void multiply(double x, double y) { Console.WriteLine($"Multiply: {x * y}"); }
        //public static void divide(double x, double y)
        //{
        //    if (y == 0)
        //    {
        //        Console.WriteLine("Cannot divide by zero");
        //    }
        //    Console.WriteLine($"divide: {x / y}");

        //}
    }
}
