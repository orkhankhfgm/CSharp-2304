using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Orkhan";
            customer.Surname = "Farajov";

            //customer.email = "";

            customer.Email = "orkhan@gmail.com";
            Console.WriteLine(customer.Email);



            Student student = new Student();
            
            student.Name = "Orkhan";
            student.Surname = "Farajov";

            //customer.email = "";

            student.Email = "or@gmail.com";
            student.DocumentSerial = "AA";
            student.DocumentNumber = "12345678";
            var docN = student.DocumentNumber;

            Console.WriteLine(student.Id);
        }
    }
}
