using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task2
{

    internal class Employee
    {
        private int id;
        private string name;
        private double salary;
        private char gender;
        private int experience;

        public int Id 
        { 
            get{ return id; }
            set { id = value; } 
        }
        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }
        public double Salary 
        { 
            get { return salary; }
            set { salary = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public Employee(int id, string name, double salary, char gender, int experience)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.gender = gender;
            this.experience = experience;
        }

        
        public static bool PromotionCriteria(Employee emp)
        {
            return emp.Experience > 5 && emp.Salary < 10000;
        }
    }
}
