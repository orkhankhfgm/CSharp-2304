using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDE
            //Console.Write("Hello ");
            //Console.Write("World");

            //Console.WriteLine("Hello");
            //Console.WriteLine("World");
            //Console.WriteLine("One");
            //Console.WriteLine("Two");
            //Console.WriteLine("Orkhan");
            //Console.ReadLine();

            /*
             (System - namespace name)
             (Console - System namespace'inin içində olan bir Class adı)
             (WriteLine - Console class'ının içində olan bir method adı)
             */

            /*
             Salam xos gelmisiniz!
             Adinizi daxil edin: 
             */
            Console.WriteLine("Salam xos gelmisiniz!");
            Console.WriteLine("Adinizi daxil edin: ");


            //var read = Console.Read(); //H
            //var readKey = Console.ReadKey();
            //var name = Console.ReadLine();
            //Console.WriteLine(readLine);
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            //Console.ReadLine();

            var surname = "Farajov";
            Console.Write(surname);
            Console.WriteLine(surname);

            /*
             1. red deyeri "qirmizi"
             2. car deyeri "avtomobil"
             3. expensive deyeri "bahali"
             4. phone deyeri "telefon"

             qirmizi avtomobil
             bahali telefon
             */

            var red = "qirmizi";
            var car = "avtomobil";
            var expensive = "bahali";
            var phone = "telefon";

            Console.Write(red);
            Console.Write(car);
            Console.WriteLine();
            Console.Write(expensive);
            Console.Write(phone);

            Console.WriteLine(red + " " + car);
            Console.WriteLine(expensive + " " + phone);

            //Console.ReadLine();


            #region Comment and Region
            //(Single-line comment)
            /*
             This
             is
             multi-line
             comment
             */
            #endregion

            #region Registration

            #endregion

            #region Login

            #endregion

            #region Profile

            #endregion

            #region Variables
            //typeOfVariable nameOfVariable = valueOfVariable

            string person = "Orkhan Farajov";

            Console.WriteLine(person);

            string anotherPerson;
            anotherPerson = "Orkhan Farajov";

            string name = "Orkhan";
            Console.WriteLine(name);

            name = "Elcin";
            Console.WriteLine(name);

            name = "Ferhad";
            Console.WriteLine(name);
            #endregion


            Console.Clear();


            #region Naming Convention
            /*
             _nameSurname //(private property adıdır)
             nameSurname
             anotherPerson
             nameSurname1
             anotherFatherName
             redCarName
             streetNumber
             countryCode
             */

            string name1 = "djhv vfdv";
            #endregion


            #region What is RAM and how does it work?
            /*
             1. S-RAM 
             2. D-RAM
             3. SD RAM
             4. DDR SD RAM //2 zolaq - 50km
             5. GDDR SD RAM //4 zolaqli - 80km
             */

            /*
             1. Value Type
             2. Referance Type
             3. Pointer Type
             */
            #endregion
        }
    }
}
