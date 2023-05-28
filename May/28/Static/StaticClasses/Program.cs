using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Static class
            //Helper helper = new Helper();
            Helper.SayHi();
            #endregion


            #region Constructor of static class
            Employee emp = new Employee();
            emp.Name = "Orkhan";
            emp.Surname = "Farajov";
            emp.Email = "orkhan";

            Employee emp2 = new Employee();
            emp2.Name = "Orkhan";
            emp2.Surname = "Farajov";
            emp2.Email = "orkhan";

            ExampleConstructorClass.ShowPersonInfo();
            ExampleConstructorClass.ShowPersonInfo();
            ExampleConstructorClass.ShowPersonInfo();
            #endregion
        }
    }
}
