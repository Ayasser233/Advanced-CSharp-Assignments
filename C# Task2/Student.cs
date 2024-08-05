using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task2
{
    internal class Student : IComparable<Student>
    {
        private int id;
        private string name;
        public int Id 
        {
            get { return id; }
            set { id = value;}
        }
        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int CompareTo(Student other)
        {
            return this.id.CompareTo(other.id);
        }
    }
}
