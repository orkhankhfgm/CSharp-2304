using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default parameter values
            ShowDate(DateTime.Now.Day, DateTime.Now.Month); //(year verməsəkdə işləyir)
            ShowDate(DateTime.Now.Day, DateTime.Now.Month, 2023); //(year verəndə verdiyimiz dəyəri alır)
            #endregion


            #region Ref and Out keywords
            int num1 = 0; //(stack'da yarandı)
            SetRef(ref num1);

            //int num2 = 0; //(7.0'dan əvvəl dəyişənə bir dəyər set edilməsi məcbur idi)
            int num2;
            SetOut(out num2);
            #endregion


            #region Flexible (dəyişkən) sayda parametr almaq/ötürmək
            #region Task in Lesson 1
            Addition(5, 10, 15, 45);
            Addition(5, 18, 15, 65, 4, 5);
            Addition(5, 18, 15, 65, 8);
            Addition(4, 5, 18, 15, 65, 7, 8, 64, 15, 4, 4, 5, 95, 74, 45, 41, 50);
            #endregion
            #endregion


            #region Overloading
            AdditionNums(5, 10);
            AdditionNums(2.4M, 5.5M);
            AdditionNums("10.2", "20.5");
            #endregion


            #region #region Use method as parameter
            //Uzun versiya
            decimal s = Subtraction(15.5M, 2.5M);
            ShowValue(s);

            //Qısa versiya
            ShowValue(Subtraction(15.5M, 2.5M));
            #endregion


            #region Local Functions
            AdditionWithLocalFunc(20, 15);

            SecondAdditionWithLocalFunc(10, 20, 30, 40);

            ThirdAdditionWithLocalFunc(10, 20, 30, 40);
            #endregion
        }

        #region Default parameter values
        public static void ShowDate(int day, int month, int year = 2022) //(year burda default value'dü)
        {
            Console.WriteLine("Tarix: {0}.{1}.{2}", day, month, year);
        }
        #endregion


        #region Ref and Out keywords
        static void SetRef(ref int intValue)
        {
            intValue = 10;
        }

        static void SetOut(out int intValue)
        {
            intValue = 15;
        }
        #endregion


        #region Flexible (dəyişkən) sayda parametr almaq/ötürmək
        static void Addition(params int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("Toplam: {0}", total);

            //(Qisa versiya)
            Console.WriteLine("Toplam: {0}", numbers.Sum());
        }

        //(yalnış: (params int[] numbers, int a))
        //(doğru:  (int a, params int[] numbers))
        #endregion


        #region Overloading
        static void AdditionNums(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine(total);
        }

        static void AdditionNums(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            Console.WriteLine(total);
        }

        static void AdditionNums(string num1, string num2)
        {
            decimal total = decimal.Parse(num1) + decimal.Parse(num2);
            Console.WriteLine(total);
        }
        #endregion


        #region Use method as parameter
        static void ShowValue(decimal num)
        {
            Console.WriteLine(num.ToString());
        }

        static decimal Subtraction(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        #endregion


        #region Local Functions
        static void AdditionWithLocalFunc(int num1, int num2)
        {
            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int result = Addition(num1, num2);

            Console.WriteLine(result);
        }


        static void SecondAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int Addition(int num1Local, int num2Local)
            {
                int SecondAddition(int num3Local, int num4Local)
                {
                    return num3Local + num4Local;
                }

                int result = SecondAddition(num3, num4);

                return result + num1Local + num2Local;
            }

            int total = Addition(num1, num2);

            Console.WriteLine(total);
        }


        static void ThirdAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int total = 0;

            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int SecondAddition(int num3Local, int num4Local)
            {
                return num3Local + num4Local;
            }

            total += Addition(num1, num2);
            total += SecondAddition(num3, num4);

            Console.WriteLine(total);
        }
        #endregion
    }
}
