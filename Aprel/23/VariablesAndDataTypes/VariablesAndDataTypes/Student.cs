using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Student(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public static implicit operator string(Student s) =>s.Name + " " + s.Surname;
        public static implicit operator int(Student s) => s.Age;
        public static implicit operator bool(Student s) => true;

        public override string ToString() => Name + " " + Surname + " " + Age;
    }
}
