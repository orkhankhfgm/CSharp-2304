using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is recursive method
            int faktorial10 = Faktorial(10);
            int faktorial0 = Faktorial(0);
            int faktorial5 = Faktorial(5);
            #endregion

            #region What is static?
            /*
             -Static nədir?
             -Staticin ram'dakı yeri
             -Static field, method, class nədir və içindəki constructor static olarsa nə olar, olmazsa nə olar.
             */

            Student student;
            //student.Surname = ""; //(error)

            Student.Test1();

            student = new Student();
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Email = "orkhankhf@gmail.com";
            student.Test();
            #endregion


            #region Where and why to use static?
            #region Task in Lesson 1
            /*
              Bir method'unuz olsun və ad soyad parametrləri alsın. Method yoxlamalıdır ki,
              ad və soyad'ın uzunluğu 20 xarakterdən uzundursa, adın ilk hərfi, nöqtə, 
              boşluq və soyad return etsin (O. Farafov). Yox əgər 20 simvoldan qısadırsa,
              ad, boşluq, soyad formatında qaytarsın. Nəzərə alın ki, ad ilə soyad arasındakı
              boşluq da 1 simvoldur (nöqtə də). Bir şeyi də nəzərə alın ki, bu method'u
              proyektin 20-30 yerində istifadə edəcəyəm.
             */

            var normalName = StringHelper.CheckFullname("Orkhan", "Farajov");
            var longFullname = StringHelper.CheckFullname("OrkhanOrkhanOrkhan", "Farajov");
            var longFullname2 = StringHelper.CheckFullname("Orkhan Middlename", "Farajov");
            var longFullname3 = StringHelper.CheckFullname("Orkhan Ibn Khayyam", "Farajov");
            #endregion

            #region Task in Lesson 2
            /*
            Bir dənə işçi class'ınız olsun və ad, soyad, email, cins və s. kimi property'ləriniz olsun. Ancaq email property'sini set
            edən zaman sadəcə @ işarəsinə qədər hissəsini set ediləcək. Yəni məsələn orkhan.farajov
            @ işarəsi və domain set olunmayacaq. Ancaq mən o class'dan istifadə edib bir işçi yaradandan sonra email ünvanını set edib
            alt sətirdə email'i get edəndə email'də @ işarəsi və domain də olacaq. Bunu edəndə encapsulation'a da uyğun edin.
             */

            Staff st = new Staff();
            st.Name = "Orkhan";
            st.Surname = "Farajov";
            st.Email = "orkhan.farajov"; //(email domaini set olmuş olacaq)
            st.Gender = 1;
            #endregion


            #region Task in Lesson 3
            Staff st1 = new Staff();
            st1.Name = "Samir";
            st1.Surname = "Samirov";
            st1.Email = "samir";
            st1.Gender = 1;

            EmailHelper.SendWelcomeMail(st.Email);

            EmailHelper.SendPasswordChangeMail(st.Email);
            #endregion
            #endregion
        }

        #region Faktorial
        static int Faktorial(int num)
        {
            if (num == 0)
                return 1;

            return num * Faktorial(num - 1);
        }
        #endregion
    }
}
