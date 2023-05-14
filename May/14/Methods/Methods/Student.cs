using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Student
    {
        /*
         Method necə yazılır?
         [access modifier] [return type] [method name] ( parameters ){
               methodun body hissəsi
         }
         
         Access Modifiers:
         1. Public
         Bir methodu public təyin etdiyimiz zaman biz əslində deyirik ki, class'a əli çatan hər yerdə bu methoddan istifadə etmək icazəsi veririk.

         2. Private
         Əgər methodumuzu private təyin etsək o zaman bu methoda yalnız və yalnız təyin etdiyimiz class daxilindən əlimiz çatır. Yəni class'ın
         içində private method təyin edəndə, bu method'u ancaq həmin class'ın içindən çağırmaq olur. Class'ları private təyin edə bilmirik.

         3. Protected //(irəliləyən dərslərdə keçəcəyik)
         4. Internal //(irəliləyən dərslərdə keçəcəyik)
         5. Internal Protected //(irəliləyən dərslərdə keçəcəyik)
         */

        public void HelloStudent()
        {
            Console.WriteLine("Salam telebe!");
        }

        private void ShowStudentInfo(string name, string surname)
        {
            Console.WriteLine("Telebe melumatlari: {0} {1}", name, surname);
        }

        public void ShowHasanInfo()
        {
            ShowStudentInfo("Hesen", "Ferecov");
        }

        public void ShowAnyStudentInfo(string a, string b)
        {
            ShowStudentInfo(a, b);
        }
    }
}
