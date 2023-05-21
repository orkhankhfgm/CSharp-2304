using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Beginning
            //OOP - Object Oriented Programming

            /*
              -Müştəri
              -Satış təmsilçisi
              -Satılacaq məhsul (Avtomobil, motosiklet və s.)

            -Müştəri
                -Ad
                -Soyad
                -Cinsiyyət
                -Passportunun seriyası və nömrəsi
                -Ünvanı

             -Məhsul
                -Marka
                -Model
                -İl
                -Km
                -Yanacaq növü
                -Ban növü

             -Təklif
                -Təklif nömrəsi
                -Müştəri
                -Satıcı
                -Məhsul
                -Qiymət

             -Sifariş
                -Sifariş nömrəsi
                -Təklif
                -Qiymət

             -Qəbz
                -Vergi nömrəsi
                -Qəbz nömrəsi
                -Seriya
                -Təklif
                -Müştəri
             */

            Console.WriteLine("I am software developer!");
            #endregion


            #region Create Class

            #endregion


            #region How to use Classes
            Customer orkhan = new Customer();

            orkhan.Name = "Orkhan";
            orkhan.Surname = "Farajov";
            orkhan.Gender = 1;
            orkhan.DocumentSerial = "AZ";
            orkhan.DocumentNumber = "123456";
            orkhan.Address = "Bakı şəh., Nərimanov r-nu., Rasim Muxtarov küç., NO 5";


            Customer otherCustomer = new Customer();

            otherCustomer = orkhan;

            otherCustomer.Name = "Name changed for otherCustomer";
            orkhan.Surname = "Surname changed for orkhan";

            otherCustomer = null;
            orkhan = null;

            //Console.WriteLine(orkhan.Name);
            //Console.WriteLine(otherCustomer.Name);
            #endregion


            #region Constructor methods
            Customer customer2 = new Customer();

            Customer ctor = new Customer();

            Customer defaultCtor = new Customer();
            Customer overload1 = new Customer("123456");
            Customer overload2 = new Customer("123123", "AA");
            Customer overload3 = new Customer("123123", "AA", "Orkhan", "Farajov");
            Customer overload4 = new Customer(1, "Orkhan", "Farajov");
            Customer overload5 = new Customer("123123", "AA", 1, "Orkhan", "Farajov", "Bakı şəh., Nərimanov r-nu., Rasim Muxtarov küç., NO 5");

            Customer orkhansInfo = new Customer("123123", "AA", 1, "Orkhan", "Farajov", "Bakı şəh., Nərimanov r-nu., Rasim Muxtarov küç., NO 5");
            Customer vahidsInfo = new Customer("123456", "AZ", 1, "Vahid", "Fereczade", "-----., NO 5");
            Customer ruzgarsInfo = new Customer("56478", "AZ", 1, "Ruzgar", "Babayev", "-----., NO 5");

            Console.WriteLine(ruzgarsInfo.Name);
            Console.WriteLine(ruzgarsInfo.Surname);
            
            Customer customer10 = new Customer();
            customer10.Name = "Seymur";
            customer10.Surname = "Ferecov";
            customer10.Address = "Filan address";
            //customer10.CheckCustomerFromDb();

            var controlResult = customer10.CheckCustomer();

            if (controlResult)
            {

            }
            else
            {

            }

            Customer test = new Customer
            {
                Name = "Orkhan",
                Surname = "Ferecov"
            };
            #endregion
        }
    }
}
