using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_SortedList_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            string[] arr = new string[2];
            string[] arr2 = new string[]
            {
                "One",
                "Two"
            };

            ArrayList ArrList = new ArrayList();

            int capacity = 0;
            int count = 0;

            ArrayList students = new ArrayList();
            students.Add("Samir");
            students.Add("Javid");
            students.Add("Teymur");
            students.Add("Gunay");
            students.Add("Aynur");
            students.Add("Zaur");

            students.Add(5);
            students.Add(true);



            #region Adding Collection to ArrayList
            //A1 sinifi
            ArrayList A1 = new ArrayList();
            A1.Add("Samir");
            A1.Add("Javid");
            A1.Add("Teymur");

            //A2 sinifi
            ArrayList A2 = new ArrayList();
            A2.Add("Gunay");
            A2.Add("Aynur");
            A2.Add("Zaur");
            A1.AddRange(A2); //A2'ni A1'ə əlavə edir
            #endregion




            #region Getting values from ArrayList
            var samir = A1[0]; //object tipindədir
            object objGunay = A1[3];
            string strGunay = A1[3].ToString();

            ArrayList mixArray = new ArrayList();
            mixArray.Add("string value");
            mixArray.Add(1);
            mixArray.Add(5.5F);
            mixArray.Add('C');
            mixArray.Add(1.2D);
            mixArray.Add(true);

            var strVal = mixArray[0].ToString();
            var numVal = (int)mixArray[1];
            var floatVal = (float)mixArray[2];
            var charVal = (char)mixArray[3];
            var doubleVal = (double)mixArray[4];
            var boolVal = (bool)mixArray[5];
            #endregion

            #region Sorting values in ArrayList
            A1.Reverse();

            A1.Sort();
            #endregion


            #region Removing values
            A1.RemoveAt(3);
            A1.RemoveRange(2, 2);
            A1.Remove("Zaur");
            #endregion


            #region Checking if value exists
            A1.Add("Malik");

            bool ct = A1.Contains("Malik");

            if (A1.Contains("Malik"))
            {
                int indexOfName = A1.IndexOf("Malik");
                A1.RemoveAt(indexOfName);
            }
            #endregion



            #region Clearing (TrimToSize) Array
            ArrayList employees = new ArrayList();
            employees.Add("Orxan");
            employees.Add("Orxan");
            employees.Add("Orxan");
            employees.Add("Orxan");
            employees.Add("Orxan");
            employees.Add("Orxan");

            for (int i = 0; i < 20000; i++)
            {
                employees.Add("Orxan");
            }

            var capacityOfEmployees = employees.Capacity;
            var countOfEmployees = employees.Count;

            employees.RemoveRange(500, 15000);

            employees.Clear();
            employees.TrimToSize();
            #endregion



            #region Task in Lesson 1
            //ev tapsirigina elave edildi
            #endregion
            #endregion

            #region HashTable
            Hashtable ht = new Hashtable();

            ht.Add("Human", "Insan");
            ht.Add("House", "Ev");
            ht.Add("You", "Sen");

            bool ct1 = ht.Contains("House");
            bool ct2 = ht.Contains("You");

            bool ctKey = ht.ContainsKey("You");
            bool ctValue = ht.ContainsValue("Ev");

            ht["House"] = "Villa";

            ht.Remove("House");

            int countOfht = ht.Count;

            ht.Clear();
            #endregion

            #region Task in Lesson 2
            /*
                Hashtable içinə ENG - AZ olaraq data əlavə ediləcək.

                Soruşulacaq:
                Yeni element əlavə etmək istəyirsiniz? H/Y
                H : Yeni element əlavə etsin
                Y : Bütün elementləri göstərsin

                Qeyd: Əgər user mövcud olan Key əlavə edirsə, bu məlumat sistemdə mövcuddur xətası versin.
             */

            Hashtable translateBase = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Elave etmek istediyiniz tercume sozunu yazin");
                Console.Write("ENG :");
                string eng = Console.ReadLine();

                bool check = translateBase.ContainsKey(eng);
                if (check)
                {
                    Console.WriteLine("Elave etmek istediyiniz soz {0} artiq sistemde movcuddur. {1} deyerinin qarsiligidir.", eng, translateBase[eng].ToString());
                }
                else
                {
                    Console.WriteLine("{0} sozunun tercumesini daxil edin: ", eng);
                    string az = Console.ReadLine();
                    translateBase.Add(eng, az);
                    Console.WriteLine("Elave olundu!");
                }

                Console.WriteLine("Yeni soz elave etmek isteyirsiniz ? ( H/Y ) ");
            }
            while (Console.ReadLine().ToUpper() != "Y");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Yol");

            foreach (var item in translateBase.Keys)
            {
                Console.WriteLine("ENG : {0} = AZ : {1}", item, translateBase[item]);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("2. Yol");

            foreach (DictionaryEntry item in translateBase)
            {
                Console.WriteLine("ENG : {0} = AZ : {1}", item.Key, item.Value);
            }
            #endregion

            #region SortedList
            SortedList sortedListEngAz = new SortedList();
            sortedListEngAz.Add("Hello", "Salam");
            sortedListEngAz.Add("Car", "Avtomobil");
            sortedListEngAz.Add("Home", "Ev");
            sortedListEngAz.Add("One", "Bir");
            //sortedListEngAz.Add(100, "Bir"); runtime error olacaq
            #endregion

            #region Stack
            Stack stack = new Stack();

            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            stack.Push("Four");

            object O1 = stack.Pop();
            object O2 = stack.Peek();
            #endregion
            
            #region Queue
            Queue queue = new Queue();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");

            object obj = queue.Peek();
            object obj1 = queue.Dequeue();
            #endregion
        }
    }
}
