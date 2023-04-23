using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        public static string Country { get; set; } = "Azerbaijan";

        static void Main(string[] args)
        {
            #region Object Type
            //həcmi: 4 byte
            //dəyər aralığı: bütün c#'dakı obyektlər/data tipləri
            //tipi: Referance-Type
            object stringVar = "My string";
            object integerVar = 55;
            object boolVar = true;
            object charVar = '?';
            object dateTimeVar = new DateTime();
            #endregion

            #region Assign one to another
            string orkhan = "Orkhan";
            string john = "John";

            orkhan = john;
            john = orkhan;

            bool isWinterCold = true;
            bool isSummerWarm = isWinterCold;
            #endregion

            #region Task in Lesson 1
            //indiki tarix
            //20 dekabr 2020
            DateTime _4 = DateTime.Now;
            DateTime _5 = new DateTime(2020, 12, 20);

            //3 dənə dəyişən təyin edəcəksiniz. Bunlar double, decimal və float tiplərində olacaq.
            //Dəyərləri də 10.5, 20.5, 30.5 olsun.

            double _1 = 10.5;
            decimal _2 = 20.5m;
            float _3 = 30.5f;
            #endregion



            #region Default values of data types
            //referance-types
            string defaultString = new String('v', 5);
            object defaultObject;
            Student defaultStudent = new Student("Orkhan", "Farajov", 28);

            //value-type
            char defaultChar;
            byte defaultByte;
            short defaultShort;
            int defaultInt;
            long defaultLong;
            double defaultDouble;
            decimal defaultDecimal;
            float defaultFloat;
            bool defaultBoolean;
            DateTime defaultDateTime;
            #endregion


            #region Local vs Global Variables
            Console.WriteLine(Country);

            ShowCountry();

            int myLocalVariable = 5;
            Console.WriteLine(myLocalVariable);

            int globalVar = 0;

            {
                int localVar1 = 555;
                globalVar += localVar1;
            }

            {
                int localVar2 = 45;
                globalVar += localVar2;
            }

            {
                int localVar3 = 50;
                globalVar += localVar3;
            }



            //Level 5 - Bütün skoplara görə global və əl çatan (Main skopu daxilində)
            int level5 = 500;
            //level4 -= 100; //level4 does not exist
            //level3 -= 100; //level3 does not exist
            //level2 -= 100; //level2 does not exist
            //level1 -= 100; //level1 does not exist

            {
                //Level 4 - Alt skoplara görə global, üst skoplara görə local
                int level4 = 400;

                level5 -= 100;
                //level3 -= 100; //level3 does not exist
                //level2 -= 100; //level2 does not exist
                //level1 -= 100; //level1 does not exist

                {
                    //Level 3 - Alt skoplara görə global, üst skoplara görə local
                    int level3 = 300;

                    level5 -= 100;
                    level4 -= 100;
                    //level2 -= 100; //level2 does not exist
                    //level1 -= 100; //level1 does not exist

                    {
                        //Level 2 - Alt skoplara görə global, üst skoplara görə local
                        int level2 = 200;

                        level5 -= 100;
                        level4 -= 100;
                        level3 -= 100;
                        //level1 -= 100; //level1 does not exist

                        {
                            //Level 1 - tamamilə local
                            int level1 = 100;

                            level5 -= 100;
                            level4 -= 100;
                            level3 -= 100;
                            level2 -= 100;
                        }
                    }
                }
            }

            int globalAge;

            {
                int localAge = 28;
                globalAge = localAge;
            }

            {
                Student localStudent = new Student("Orkhan", "Farajov", 28);
                localStudent.Age = globalAge;
            }
            #endregion

            Console.Clear();

            #region Simple form app
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Salam, xoş gəlmisiniz!");

            Console.WriteLine("Adınızı daxil edin: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadınızı daxil edin: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Doğulduğunuz ölkəni daxil edin: ");
            string country = Console.ReadLine();

            Console.WriteLine("Boyunuzu daxil edin: ");
            string height = Console.ReadLine();

            Console.WriteLine("Çəkinizi daxil edin: ");
            string weight = Console.ReadLine();

            Console.WriteLine("Ad: " + name);
            Console.WriteLine("Soyad: " + surname);
            Console.WriteLine("Ölkə: " + country);
            Console.WriteLine("Boy: " + height);
            Console.WriteLine("Çəki: " + weight);
            Console.Clear();
            #endregion


            #region Task in Lesson 2
            /*
             1. Xos geldin mesaji,
             2. adini oyrenin //Orxan
             3. muraciet qaydasini (bey)
             4. Orxan bey nece yasiniz var?
             */

            Console.WriteLine("Salam, xoş gəlmisiniz!");

            Console.WriteLine("Adınızı daxil edin: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Sizə necə müraciət edə bilərəm? (bəy/xanım)");
            string genderPrefix = Console.ReadLine();

            Console.WriteLine(userName + " " + genderPrefix + " " + "neçə yaşınız var?");
            string ageOfUser = Console.ReadLine();
            #endregion


            #region Type Conversion

            #region Implicit Type Conversion
            //byte 255
            //short 32767

            //Nümunə 1:
            byte byteVal = byte.MaxValue;
            short shortVal = short.MaxValue;
            short takeByteVal = byteVal; //(implicit conversion)
            //byte takeShortVal = shortVal;

            //Nümunə 2:
            int takeShortVal = shortVal; //(implicit conversion)
            
            //Nümunə 3:
            int takeBtVal = byteVal; //(implicit conversion)

            //Nümunə 4:
            int i = 5000;
            long l = i;

            long l2 = 5000000;
            float f = l2;

            float f2 = 25.6F;
            double d = f2;

            //i = f2;

            //Cannot implicitly convert A to B. An explicit conversion exists
            //Cannot implicitly convert, A to B

            //Ardıcıllıq: byte -> short -> int -> long -> float -> double
            #endregion


            #region Signed - Unsigned Data Types
            //Unsigned data types:
            byte us1 = byte.MinValue;     //8-bit  | 0 ilə 255
            ushort us2 = ushort.MinValue; //16-bit | 0 ilə 65.535
            uint us3 = uint.MinValue;     //32-bit | 0 ilə 4.294.967.295
            ulong us4 = ulong.MinValue;   //64-bit | 0 ilə 18.446.744.073.709.551.615

            //Signed data types:
            sbyte s1 = sbyte.MinValue;    //8-bit  | -128 ilə 127
            short s2 = short.MinValue;    //16-bit | -32.768 ilə 32.767
            int s3 = int.MinValue;        //32-bit | -2.147.483.648 ilə 2.147.483.647
            long s4 = long.MinValue;      //64-bit | -9.223.372.036.854.775.808 - 9.223.372.036.854.775.807

            /*
             unsigned ushort: 0 ilə 65.535;
             signed short: -32.768 ilə 32.767

             32.767 - 65.535 = -32.768
             */
            #endregion


            #region Explicit Conversion
            //Nümunələr:
            int a = 20000;
            //short b = a;

            double c = 785.3;
            //float d2 = c;

            short e = 10;
            //ushort f3 = e;

            float g = 15.2f;
            //long h = g;

            long i1 = 1000000;
            //int j = i1;

            //Yazılış qaydası: hədəfTip a = (hədəfTip)qaynaqTip;

            long k = 10000000000000;
            int q = (int)k;

            //Ardıcıllıq: double -> float -> long -> int -> char
            #endregion


            #region Checked & Unchecked keywords
            long longVar = Convert.ToInt64(Console.ReadLine()); //99999999999
            int takeLongVar = (int)longVar;

            short shortVar = Convert.ToInt16(Console.ReadLine()); //30000
            byte takeShortVar = (byte)shortVar;

            //Casting with Checked keyword
            checked
            {
                long longVar1 = Convert.ToInt64(Console.ReadLine()); //99999999999
                int takeLongVar1 = (int)longVar1;
            }

            checked
            {
                int money = Convert.ToInt32(Console.ReadLine()); //100.000 / 10
                short takeInt = (short)money;

                unchecked
                {
                    byte age = Convert.ToByte(Console.ReadLine()); //200
                    sbyte takeByte = (sbyte)age;
                }
            }
            #endregion

            #region Helper Class Conversions
            string numberString = "50";
            int number;

            //Implicit Convertion nümunəsi:
            //number = numberString;

            //Explicit Convertion nümunəsi:
            //number = (int)numberString;

            number = Convert.ToInt32(numberString);

            //Not possible:
            //bool booleanVariable = 1;
            //bool booleanVariable = (bool)1;
            //int integerVariable = (int)"1";
            //int integerVariable = (int)true;

            //Possible:
            bool booleanVariable;
            booleanVariable = Convert.ToBoolean(1); //true
            booleanVariable = Convert.ToBoolean("true"); //true
            booleanVariable = Convert.ToBoolean(null); //false
            booleanVariable = Convert.ToBoolean(0); //false
            //booleanVariable = Convert.ToBoolean("Orxan"); //error

            string numString = "45";
            //short stringToShort = numString;
            //short stringToShort = (short)numString;
            short stringToShort = Convert.ToInt16(numString);
            
            //int stringToInt = numString;
            //int stringToInt = (int)numString;
            int stringToInt = Convert.ToInt32(numString);

            //long stringToLong = numString;
            //long stringToLong = (int)numString;
            long stringToLong = Convert.ToInt64(numString);



            //Source data types
            int dt1 = 10;
            long dt2 = 10;
            bool dt3 = true;
            char dt4 = 'T';
            byte dt5 = 10;

            //Destination data type
            string destDataType;
            destDataType = dt1.ToString();
            destDataType = dt2.ToString();
            destDataType = dt3.ToString();
            destDataType = dt4.ToString();
            destDataType = dt5.ToString();


            bool _boolVariable = Convert.ToBoolean("false");       //false //(0/1 yazsaq error verəcək)
            byte _byteVariable = Convert.ToByte("10");             //unsigned
            char _charVariable = Convert.ToChar("A");
            DateTime _dateTimeVariable = Convert.ToDateTime("2020-12-12");
            decimal _decimalVariable = Convert.ToDecimal("15.2");
            double _doubleVariable = Convert.ToDouble("15.2");
            short _shortVariable = Convert.ToInt16("-25000");      //signed
            int _intVariable = Convert.ToInt32("1500000");
            long _longVariable = Convert.ToInt64("200000000000");
            sbyte _sByteVariable = Convert.ToSByte("12");
            ushort _ushortVariable = Convert.ToUInt16("20");       //unsigned
            uint _uintVariable = Convert.ToUInt32("6000");         //unsigned     
            ulong _ulongVariable = Convert.ToUInt64("8888000000"); //unsigned
            #endregion

            #region User Defined Conversion
            Student student = new Student("Orkhan", "Farajov", 28);

            string strStudent = student;
            string strStudentCast = (Student)student;

            int stAge = student;
            int stAgeCast = (Student)student;

            bool stBool = student;
            bool stBoolCast = (Student)student;

            string strStudentToString = student.ToString();
            #endregion
            #endregion
        }

        static void ShowCountry()
        {
            Console.WriteLine(Country);
        }
    }
}
