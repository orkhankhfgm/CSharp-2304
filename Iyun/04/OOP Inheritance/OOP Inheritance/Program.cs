﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            //car.ToString();
            //car.Model

            Student student = new Student();
            student.Id = 1000;
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Age = 27;
            student.ClassName = "11A";
            student.Degree = "Some Degree";
            student.RegDate = DateTime.Now;



            Teacher teacher = new Teacher();
            teacher.Id = 2000;
            teacher.Name = "Orkhan";
            teacher.Surname = "Farajov";
            teacher.Age = 27;
            teacher.IsProfessor = false;
            teacher.Branch = "Some Branch";
            teacher.RegDate = DateTime.Now;

            //(sonradan editləndi)
            teacher.IsProfessor = true;
            teacher.EditDate = DateTime.Now;



            Employee employee = new Employee();
            employee.Id = 3000;
            employee.Name = "Orkhan";
            employee.Surname = "Farajov";
            employee.Age = 27;
            employee.JobTitle = "Software Developer";
            employee.Salary = 100;
            employee.RegDate = DateTime.Now;
        }
    }
}
