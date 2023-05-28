using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class ExampleConstructorClass
    {
        //public ExampleConstructorClass() //error
        //{

        //}

        static ExampleConstructorClass()
        {
            Console.WriteLine("ctor...");
        }

        public static void ShowPersonInfo()
        {
            Console.WriteLine("Name: Orkhan");
            Console.WriteLine("Surname: Farajov");
            Console.WriteLine("Age: 28");
        }
    }
}
