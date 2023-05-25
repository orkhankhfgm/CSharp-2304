using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomeworks
{
    public class HomeworkStudentNames
    {
        /*
            4. Bir dənə kiçik console app yazın. Bu app sizdən sinif adı soruşacaq. Məsələn 1A, 1B və s. daxil ediləcək. Sonra sinif rəhbərinin adı
            soruşulacaq. Axırda isə, 10 tələbə adı soruşulacaq. Bu tələbələrin adlarını array'dan istifadə etmədən 10 ayrı string dəyişəndə
            saxlayın student1, student2, student3... və sonra sinif adı, müəllim adı, tələbələrin adlarını göndərə biləcəyiniz bir method yazın.
            Method cəmi 3 parametr qəbul edə bilər. 3-dən artıq parametr istifadə etmək haqqınız yoxdur. Axırda sinif haqqında məlumat yazısı
            və onun altında sinif adı, sinif rəhbərinin adı və tələbə adları alt-alta yazılsın. Tələbə adlarını da collection və ya list
            şəklində göndərmək haqqınız yoxdur. İp ucu verim dərsdə keçmişdik.
        */

        public static void GetInfo()
        {
            string teacherName = "Samir";
            string className = "A1";

            string student1 = "t1";
            string student2 = "t2";
            string student3 = "t3";
            string student4 = "t4";
            string student5 = "t5";
            string student6 = "t6";
            string student7 = "t7";
            string student8 = "t8";
            string student9 = "t9";
            string student10 = "t10";
            ShowInfo(teacherName, className, student1, student2, student3, student4, student5, student6, student7, student8, student9, student10);
        }

        public static void ShowInfo(string teacherName, string className, params string[] students)
        {
            Console.WriteLine(teacherName);
            Console.WriteLine(teacherName);

            //1 version
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}

            //2 version
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }

    }
}
