using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1: İstifadəçidən 2 dənə ayrı dəyər alın(rəqəm). Məsələn birincidə istifadəçi 20 daxil etdi onu a dəyişənində saxlayın. İkincidə 50 daxil etdi onu da
                       b dəyişənində saxlayın. Elə edin ki, bu iki dəyişənin dəyərlərinin yerlərini dəyişdirin. Yəni a 20, b 50-dirsə elə edin ki, a olsun 50, b olsun 20.
             */

            //int a, b, c;
            //Console.WriteLine("Birinci reqemi daxil edin: ");
            //a = int.Parse(Console.ReadLine()); //20

            //Console.WriteLine("Birinci reqemi daxil edin: ");
            //b = int.Parse(Console.ReadLine()); //50

            //c = a;
            //a = b;
            //b = c;

            /*
             Homework 2: İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın. İstifadəçi 3-cü rəqəmi daxil etdikdən sonra ekrana belə bir yazı yazdırın Nəticə: 5 + 5 + 10 = 20. Bunu
                         çıxma, vurma və bölmə üçün də edin.
             */

            //int num1, num2, num3;

            //Console.WriteLine("1-ci reqemi daxil edin: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2-ci reqemi daxil edin: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("3-ci reqemi daxil edin: ");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //int result = num1 + num2 + num3;
            //Console.WriteLine("Nəticə: " + num1 + " + " + num2 + " + " + num3 + " = " + result);


            /*
             Homework 3: İstifadəçidən 10 dənə fərqli rəqəm alıb bir dəyişəndə toplayın. Bu taskı da çıxma, vurma və bölmə üçün də edin. Çıxmada və toplama əməliyyatlarında 10-cu dəyər daxil
                         edildikdən sonra alınan nəticəyə 1 toplayacaq və ya çıxacaqsız. Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.
             */

            //int num4 = 0;
            //Console.WriteLine("10 deyer daxil edin: ");

            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4++;
            //Console.WriteLine("Netice: " + num4);




            int num5 = 80000;
            Console.WriteLine("10 deyer daxil edin: ");

            num5 -= Convert.ToInt32(Console.ReadLine());
            num5 -= Convert.ToInt32(Console.ReadLine());
            num5 -= Convert.ToInt32(Console.ReadLine());
            num5 -= Convert.ToInt32(Console.ReadLine());
            num5 -= Convert.ToInt32(Console.ReadLine());
            num5 -= Convert.ToInt32(Console.ReadLine());
            num5 -= Convert.ToInt32(Console.ReadLine());
            num5 -= Convert.ToInt32(Console.ReadLine());
            num5 -= Convert.ToInt32(Console.ReadLine());
            num5 -= Convert.ToInt32(Console.ReadLine());
            num5--;
            Console.WriteLine("Netice: " + num5);
        }
    }
}
