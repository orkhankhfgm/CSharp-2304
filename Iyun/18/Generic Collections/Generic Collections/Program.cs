using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Before Generic Collections
            VirtualDatabase virtualDb = new VirtualDatabase();
            virtualDb.Add(10);
            virtualDb.Add(20);
            #endregion


            #region Using simple Generic Collections
            //Not Generic Collection
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Bir");

            //<T> : T tipi, .NET framework'unun içində olan və ya bizim yaratdığımız
            //hər-hansısa bir tipi qəbul edən generic'dir.

            List<int> genericList = new List<int>();
            genericList.Add(5);
            genericList.Add(15);
            genericList.Add(25);

            List<string> names = new List<string>();
            names.Add("Orkhan");
            names.Add("Ceyhun");
            names.Add("Davud");

            List<bool> booleanGC = new List<bool>();
            booleanGC.Add(true);
            booleanGC.Add(false);
            booleanGC.Add(false);
            #endregion


            #region Using custom types with Generic Collection and Linq methods
            List<Student> students = new List<Student>();

            //(1-ci yol)
            students.Add(new Student()
            {
                Id = 1,
                Name = "Cavid",
                Surname = "Cavidov",
                Age = 25
            });

            //(2-ci yol)
            Student student = new Student()
            {
                Id = 2,
                Name = "Hasan",
                Surname = "Hasanov",
                Age = 23
            };
            students.Add(student);

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3}",
                                  students[i].Id,
                                  students[i].Name,
                                  students[i].Surname,
                                  students[i].Age);
            }

            foreach (var item in students)
            {
                Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3}",
                                  item.Id,
                                  item.Name,
                                  item.Surname,
                                  item.Age);
            }
            #endregion



            #region Task in Lesson 1
            List<int> numbers = new List<int>();
            numbers.Add(1);

            int[] numbersToAdd = new int[10];

            numbersToAdd[0] = 10;
            numbersToAdd[1] = 20;
            numbersToAdd[2] = 30;
            numbersToAdd[3] = 40;
            numbersToAdd[4] = 50;
            numbersToAdd[5] = 60;
            numbersToAdd[6] = 70;
            numbersToAdd[7] = 80;
            numbersToAdd[8] = 90;
            numbersToAdd[9] = 100;

            //(1. yol)
            for (int i = 0; i < numbersToAdd.Length; i++)
            {
                numbers.Add(numbersToAdd[i]);
            }

            //(2. yol (yeni məlumat))
            numbers.AddRange(numbersToAdd);
            #endregion


            List<double> doubleList = new List<double>();
            doubleList.Add(10.1);
            doubleList.Add(20.1);
            doubleList.Add(30.1);
            doubleList.Add(40.1);

            var capacityOfDoubleList = doubleList.Capacity; //4
            var countOfDoubleList = doubleList.Count;

            doubleList.Add(50.1);

            var secondCapacityOfDoubleList = doubleList.Capacity;
            var secondCountOfDoubleList = doubleList.Count;

            doubleList.TrimExcess();

            doubleList.ForEach(i => Console.WriteLine(i));


            #region Generic Collections general
            List<int> secondNumbers = new List<int>();
            secondNumbers.Add(1);
            secondNumbers.Add(2);
            secondNumbers.Add(3);
            secondNumbers.Add(4);
            secondNumbers.Add(5);
            secondNumbers.Add(6);

            int no = secondNumbers[1];

            secondNumbers.Insert(1, 25);

            var control1 = secondNumbers.Any();
            var control2 = secondNumbers.Any(i => i > 3);
            var control3 = secondNumbers.Any(i => i > 30);

            //(A-Z və ya 1-N sıralama)
            secondNumbers.Sort();

            //(Z-A və ya N-1 sıralama)
            secondNumbers.Reverse();


            bool delResult = secondNumbers.Remove(6);
            int removedItemCount = secondNumbers.RemoveAll(i => i > 4);

            secondNumbers.Add(10);
            secondNumbers.Add(15);
            secondNumbers.Add(20);
            secondNumbers.Add(25);

            secondNumbers.RemoveAt(2);
            secondNumbers.Clear();


            int maxValue = numbers.Max();
            int minValue = numbers.Min();
            int sumValue = numbers.Sum();
            #endregion
        }
    }
}
