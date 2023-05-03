using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PastHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             Əvvəlcədən iki dəyişəndə username və password saxlayın. Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. Yəni proqramda belə dəyişdirmək mümkün olmasın
             Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
             Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.
             */

            const string username = "admin";
            const string password = "admin";

            Console.WriteLine("Istifadeci adini daxil edin: ");
            string u = Console.ReadLine();

            Console.WriteLine("Sifrenizi daxil edin: ");
            string p = Console.ReadLine();

            if (u == username && p == password)
            {
                Console.WriteLine("Sisteme daxil olundu!");
            }
            else
            {
                Console.WriteLine("Istifadeci adini daxil edin: ");
                u = Console.ReadLine();

                Console.WriteLine("Sifrenizi daxil edin: ");
                p = Console.ReadLine();

                if (u == username && p == password)
                {
                    Console.WriteLine("Sisteme daxil olundu!");
                }
                else
                {
                    Console.WriteLine("Istifadeci adini daxil edin: ");
                    u = Console.ReadLine();

                    Console.WriteLine("Sifrenizi daxil edin: ");
                    p = Console.ReadLine();

                    if (u == username && p == password)
                    {
                        Console.WriteLine("Sisteme daxil olundu!");
                    }
                    else
                    {
                        Console.WriteLine("Hesab bloklandi!");
                    }
                }
            }

            /*
             Homework 2:
             Switch-case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. Toplama, çıxma, vurma
             və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
             istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.
             */

            string m = "mainMenu";
            decimal a = 0, b = 0;

            switch (m)
            {
                case "mainMenu":
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("A deyeri daxil edin: ");
                    a = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("B deyeri daxil edin: ");
                    b = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Etmek istediyiniz emeliyyati secin: ");
                    Console.WriteLine("1. Toplama");
                    Console.WriteLine("2. Cixma");
                    Console.WriteLine("3. Vurma");
                    Console.WriteLine("4. Bolme");

                    short choise = Convert.ToInt16(Console.ReadLine());
                    if (choise == 1)
                        goto case "toplama";
                    else if (choise == 2)
                        goto case "cixma";
                    else if (choise == 3)
                        goto case "vurma";
                    else if (choise == 4)
                        goto case "bolme";
                    else
                        Console.WriteLine("Yanlis emeliyyat novu secildi!");
                        goto case "mainMenu";
                case "toplama":
                    Console.WriteLine("Netice: " + (a + b));
                    goto case "mainMenu";
                case "cixma":
                    Console.WriteLine("Netice: " + (a - b));
                    goto case "mainMenu";
                case "vurma":
                    Console.WriteLine("Netice: " + (a * b));
                    goto case "mainMenu";
                case "bolme":
                    if(b == 0)
                        Console.WriteLine("Deyer 0-a bolune bilmez!");
                    else
                        Console.WriteLine("Netice: " + (a / b));
                    goto case "mainMenu";
            }
        }
    }
}
