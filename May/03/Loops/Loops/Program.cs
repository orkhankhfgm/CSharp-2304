using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
            

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Salam");
            }

            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            for (int i = 0; i < 8; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            for (int i = 0; i < 100; i += 10)
                Console.WriteLine(i);

            Console.Clear();


            //int counter = 0;
            //for (; ; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //for (; ;)
            //    Console.WriteLine("test");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Console.WriteLine("i: " + i + " ---- " + "a: " + a);
                }
                Console.WriteLine("____________________");
            }

            Console.Clear();

            //for (int a1 = 0; a1 < 10; a1++)
            //{
            //    for (int b1 = 0; b1 < 10; b1++)
            //    {
            //        for (int c1 = 0; c1 < 10; c1++)
            //        {
            //            for (int d1 = 0; d1 < 10; d1++)
            //            {
            //                Console.WriteLine("a:" + a1 + " --- b:" + b1 + " --- c:" + c1 + " --- d:" + d1);
            //            }
            //        }
            //    }
            //}

            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Clear();

            #region Task in Lesson 1
            /*
             Task 1: 1-dən 100-ə qədər olan rəqəmlərin toplamını ekrana yazdırın.
             Task 2: Sadəcə cüt rəqəmlərin toplamını ekrana yazdırın.
             */
            
            //Solution 1
            int result = 0;

            for (int i = 1; i <= 100; i++)
                result += i;

            Console.WriteLine("1-100 arasi reqemlerin toplami: " + result);

            result = 0;

            //Solution 2
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0)
                    result += i;
            }
            Console.WriteLine("1-100 arasi cut reqemlerin toplami: " + result);


            #endregion
            #endregion



            #region While Loop
            //var continueLoop = true;

            //while (continueLoop)
            //{
            //    int sec = DateTime.Now.Second;

            //    if(sec > 30 && sec < 45)
            //    {
            //        Console.WriteLine("End");
            //        break;
            //    }
            //    else
            //        Console.WriteLine(sec);
            //}


            int countWhile = 1;
            while (countWhile <= 100)
            {
                Console.WriteLine("Counter: " + countWhile);
                countWhile++;
            }


            #region Task in Lesson 2
            ////Solution 1
            //while (true)
            //{
            //    string text = Console.ReadLine();

            //    if (text != "exit")
            //        Console.WriteLine(text);
            //    else
            //        break;
            //}

            ////Solution 2
            //var stopLoop = false;

            //while (!stopLoop)
            //{
            //    string text = Console.ReadLine();

            //    if (text != "exit")
            //        Console.WriteLine(text);
            //    else
            //        stopLoop = true;
            //}
            #endregion
            #endregion



            #region Do-While Loop
            bool startChat = false;

            while (startChat)
            {
                if(startChat == false)
                {
                    Console.WriteLine("Sohbet basladilsin? He/Yox");
                    string answer = Console.ReadLine();

                    if (answer == "He")
                        startChat = true;
                    else if (answer == "Yox")
                        break;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sehv cavab daxil etdiniz!");
                        Console.WriteLine("Sohbet basladilsin? He/Yox");
                    }
                }
                else
                {
                    Console.WriteLine("Mesajinizi daxil edin: ");
                    string text = Console.ReadLine();

                    if (text == "exit")
                        break;

                    Console.WriteLine(text);
                }
            }



            do
            {
                if (startChat == false)
                {
                    Console.WriteLine("Sohbet basladilsin? He/Yox");
                    string answer = Console.ReadLine();

                    if (answer == "He")
                        startChat = true;
                    else if (answer == "Yox")
                        break;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sehv cavab daxil etdiniz!");
                        Console.WriteLine("Sohbet basladilsin? He/Yox");
                    }
                }
                else
                {
                    Console.WriteLine("Mesajinizi daxil edin: ");
                    string text = Console.ReadLine();

                    if (text == "exit")
                        break;

                    Console.WriteLine(text);
                }
            } while (startChat);



            while (5 == 7)
            {
                //bura hec vaxt dusmeyecek
            }

            do
            {
                //bura en az bir defe de olsun dusecek
            } while (5 == 7);
            #endregion




            #region Foreach loop
            string[] names = new string[5];
            names[0] = "Orkhan";
            names[1] = "Zaur";
            names[2] = "Samir";
            names[3] = "Cavid";
            names[4] = "Hikmet";

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            #endregion




            #region Variable declarations inside/outside loop bodies
            string globalVariableName = "Orkhan";

            for (int i = 0; i < 5; i++)
            {
                globalVariableName = "Name can be changed here";
            }

            for (int i = 0; i < 5; i++)
            {
                string localVariableSurname = "Farajov";
            }

            //localVariableSurname = "Surname can't be changed here";

            Random rand = new Random();
            int getNumber = rand.Next(1, 100);
            int getOtherNumber = rand.Next(1000, 9999);
            #endregion


            Console.ReadLine();
        }
    }
}
