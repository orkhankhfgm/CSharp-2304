using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is method
            //1. Void type methods
            //2. Return type methods

            SayHello();
            #endregion

            #region Practise with methods
            Student studentInstance = new Student();
            studentInstance.HelloStudent();

            studentInstance.ShowHasanInfo();

            string name = "Orkhan";
            string surname = "Farajov";

            studentInstance.ShowAnyStudentInfo(name, surname);

            Console.Clear();
            #endregion
        }


        static void SayHello()
        {
            Console.WriteLine("Salam");

        }
    }
}
