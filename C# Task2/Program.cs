using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task2
{
    internal class Program
    {
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
            Student[] student = new Student[5];

            student[0] = new Student(4, "Ali");
            student[1] = new Student(5, "Ahmed");
            student[2] = new Student(3, "Sara");
            student[3] = new Student(1, "Sana");
            student[4] = new Student(2, "Soha");

            Console.WriteLine("Unsorted Students: ");

            foreach (var students in student)
            {
                Console.WriteLine($"Id: {students.Id}, Name: {students.Name}");
            }
            Array.Sort(student);
            Console.WriteLine("\nSorted Students: ");
            foreach (var students in student)
            {
                Console.WriteLine($"Id: {students.Id}, Name: {students.Name}");
            }

            try
            {
                Array.Resize(ref student, 6);
                student[5] = new Student(6, "sayed");

                Console.WriteLine("\nAfter Resize: ");
                foreach (var students in student)
                {
                    Console.WriteLine($"Id: {students.Id}, Name: {students.Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion
            Console.ReadKey();
        }
    }
}
