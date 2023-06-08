using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sealed class
            /*
             object => Person =>
                                 Employee
                                 Student X
                                 Teacher X
             */

            Test test = new Test();
            #endregion



            #region Protected access modifier
            /*
             public:
             private:
             protected:

             //Not: Heç bir class private və ya protected təyin edilə bilməz. Ancaq class'ın daxilində
                    olan property, field və s. üçün keçərlidir.
             */

            Teacher teacher = new Teacher();
            teacher.Test();
            #endregion
        }
    }
}
