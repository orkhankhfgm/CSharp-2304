using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance_Part_2_and_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

            Student student = new Student();

            Person person = new Person();
            person.GoodPerson();

            Teacher teacher2 = new Teacher();
            teacher2.GoodPerson();



            #region Assignment sub class to parent class
            Student student1 = new Student();
            object obj = student1;
            
            //Student s1 = obj;

            Student s1 = (Student)obj;

            Person p1;

            p1 = s1;
            p1 = new Student();

            //s1 = new Person();
            s1 = (Student)new Person();

            object objPerson = new Person();
            object objStudent = new Student();
            object objTeacher = new Teacher();
            #endregion
        }
    }
}
