﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
    }
}
