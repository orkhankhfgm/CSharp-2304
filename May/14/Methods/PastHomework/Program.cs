using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             İlk öncə aşağıdakı kimi bir menu çıxsın ekranda.

                Menu:
                1 - Element elave et
                2 - Elementleri goster
                3 - Element axtar
                4 - Element editle
                5 - Element sil
                6 - Exit
                Emeliyyat novunu secin:

                Əməliyyat növünü user seçdikdən sonra aşağıdakı kimi proses davam edəcək...
                1:
                Soruşacaq: "Zehmet olmasa elave etmek istediyiniz elementi daxil edin: "
                Daxil edəndən sonra: "Element elave olundu!"

                2:
                Bunu seçəndə bütün elementlər aşağıdakı kimi göstəriləcək.
                1. Element = 15
                2. Element = Salam
                3. Element = Hi
                Burdan çıxmaq üçündə "Davam etmek ucun Enter'e basin" yazısı görsənəcək.

                3:
                Bunu seçəndə aşağıdakı yazı çıxacaq.
                "Axtarmaq istediyiniz elementi daxil edin: "
                Daxil edəndən sonra əgər tapılıbsa, aşağıdakı yazı çıxsın
                "Element tapildi : Index :0 - Deyer: Salam"
                tapılmayıbsa bu yazı çıxsın
                "Axtardiginiz element tapilmadi".

                4:
                "Editlemek istediyiniz elementi daxil edin : " yazısı çıxsın və məsələn Salam sözünü editləmək istəyirsə,
                ilk öncə yoxlayın Salam elementi var mı? Yoxdursa bu yazı çıxsın:
                "Axtardiginiz element tapilmadi"
                Varsa:
                "Salam elementini ne ile evezlemek isteyirsiniz?"
                Editləyəndən sonra da "Element editlendi!" yazısı çıxsın.

                5:
                İlk öncə bunu soruşsun:
                "Butun elementleri silmek isteyirsiniz? (H/Y)"
                əgər cavab H olarsa o zaman bütün elementləri silib "Butun elementler silindi" yazısı çıxsın.
                əgər cavab Y olarsa o zaman "Silmek istediyiniz elementi daxil edin: " yazısı çıxsın və məsələn adam Salam daxil etdisə 
                ilk öncə yoxlayın Salam var mı? Varsa silib "Element silindi" yazın yoxdursa "Silmek istediyiniz element tapilmadi!" yazısı
                çıxsın.
             */


            string choose;
            ArrayList array = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Element elave et");
                Console.WriteLine("2 - Elementleri goster");
                Console.WriteLine("3 - Element axtar");
                Console.WriteLine("4 - Element editle");
                Console.WriteLine("5 - Element sil");
                Console.WriteLine("6 - Exit");
                Console.WriteLine("Emeliyyat novunu secin: ");
                choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Console.Write("Zehmet olmasa elave etmek istediyiniz elementi daxil edin: ");
                        string val = Console.ReadLine();
                        array.Add(val);
                        Console.WriteLine("Element elave olundu!");
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case "2":
                        for (int i = 0; i < array.Count; i++)
                        {
                            Console.WriteLine("{0}. Element = {1}", i, array[i]);
                        }
                        Console.WriteLine("Davam etmek ucun Enter'e basin");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("Axtarmaq istediyiniz elementi daxil edin: ");
                        string searchKey = Console.ReadLine();
                        bool control = array.Contains(searchKey);
                        if (control)
                        {
                            int index = array.IndexOf(searchKey);
                            string foundValue = array[index].ToString();
                            Console.WriteLine("Element tapildi : Index : {0} - Deyer : {1}", index, foundValue);
                        }
                        else
                        {
                            Console.WriteLine("Axtardiginiz element tapilmadi");
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case "4":

                        Console.WriteLine("Editlemek istediyiniz elementi daxil edin : ");
                        string editElement = Console.ReadLine();

                        if (!array.Contains(editElement))
                        {
                            Console.WriteLine("Axtardiginiz element tapilmadi");
                            break;
                        }

                        Console.WriteLine("{0} elementini ne ile evezlemek isteyirsiniz?", editElement);
                        string newElement = Console.ReadLine();

                        int indexEdit = array.IndexOf(editElement);
                        array[indexEdit] = newElement;
                        Console.WriteLine("Element editlendi!");

                        System.Threading.Thread.Sleep(2000);

                        break;

                    case "5":
                        Console.WriteLine("Butun elementleri silmek isteyirsiniz? (H/Y)");
                        string answer = Console.ReadLine();

                        if (answer.ToUpper() == "H")
                        {
                            array.Clear();
                            array.TrimToSize();
                            Console.WriteLine("Butun elementler silindi");
                        }
                        else
                        {
                            Console.WriteLine("Silmek istediyiniz elementi daxil edin: ");
                            string delElement = Console.ReadLine();
                            if (array.Contains(delElement))
                            {
                                array.Remove(delElement);
                                Console.WriteLine("Element silindi");
                            }
                            else
                            {
                                Console.WriteLine("Silmek istediyiniz element tapilmadi!");
                            }
                        }

                        System.Threading.Thread.Sleep(2000);

                        break;

                    default:
                        break;
                }
            } while (choose != "6");
        }
    }
}
