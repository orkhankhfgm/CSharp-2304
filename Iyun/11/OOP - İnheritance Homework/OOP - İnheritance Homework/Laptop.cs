using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___İnheritance_Homework
{
    public sealed class Laptop : Item
    {
        public string CPU { get; set; }
        public string Ram { get; set; }
        public string GraphicCard { get; set; }
    }
}
