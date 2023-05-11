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
             Homework 1:
                Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız. Bunun üçün öncə bütün elementlərin toplamını
                tapın sonra onu array'dakı element sayına bölün. Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq
                bir array yaradacaq. Arrayı yaratdıqdan sonra bütün elementlərinin dəyərlərini istifadəçidən soruşub array'ı doldurun.
                Axırda da elementlərin toplamını və ortalama dəyərini ekrana yazdırın. Bunu həm for döngüsüylə edin həm də foreach.
             */

            //Solution 1:
            Console.WriteLine("Array uzunlugunu daxil edin: ");
            int arrLength = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLength];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}. index: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array dolduruldu!");

            Console.WriteLine("Arrayin elementlerinin toplami ve ortalama deyeri barede melumat: ");
            Console.WriteLine("------------------------------------------------------------------------");

            int total = 0, average = 0;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
                total += item;
            }

            Console.WriteLine("------------------------");

            Console.WriteLine(total);

            Console.WriteLine("Arrayin icindeki toplam element sayi: {0}", arr.Length);

            average = total / arr.Length;

            Console.WriteLine("Ortalama : {0}", average);
            Console.WriteLine("------------------------");



            /*
             Homework 2:
                int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 }; bu arrayın içindəki elementləri kiçikdən böyüyə sıralayın. Ancaq bunu edərkən sort və reverse
                method'larından istifadə etmək olmaz :). Alqoritmasını özünüz düşünün.
             */
            //Solution 2:
            int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 };
            int temp, j;

            for (int i = 1; i < numArr.Length; i++)
            {
                if (numArr[i] < numArr[i - 1])
                {
                    temp = numArr[i];

                    for (j = i; j > 0 && temp < numArr[j - 1]; j--)
                        numArr[j] = numArr[j - 1];

                    numArr[j] = temp;
                }
            }

            foreach (var i in numArr)
            {
                Console.WriteLine(i);
            }

            /*
             Homework 3:
                Bir array'a Random() ilə 1-100000 arası 100 ədəd rəqəm yığın. Sonra həmin array'dakı ən kiçik və ən böyük rəqəmləri tapın. Əlavə olaraqda bütün rəqəmlərin
                toplamını ekrana yazdırın.
             */

            //Solution: 3
            int[] randNums = new int[100];
            Random rand = new Random();

            int min = 100000;
            int max = 0;
            int sum = 0;

            for (int i = 0; i < randNums.Length; i++)
            {
                randNums[i] = rand.Next(1, 100000);

                if (randNums[i] > max)
                    max = randNums[i];

                if (randNums[i] < min)
                    min = randNums[i];

                sum += randNums[i];
            }

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Sum: " + sum);

        }
    }
}
