using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance_Part_3
{
    public class Employee : Person
    {
        public string Sector { get; set; }
        public int WorkType { get; set; } //PartTime = 1 / FullTime = 0
        public decimal Salary { get; set; }
    }
}
