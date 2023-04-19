using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nümunə 1:
            int aValue; //4 byte
            aValue = 5200;
            Console.WriteLine(aValue);

            //Nümunə 2:
            int bValue;
            bValue = 12;
            bValue = 17;

            int i = 2147483647; //4 byte
            double x = 500; //8 byte

            x = i;
            x = 150;


            #region Referance Type Variables
            Student student;
            //student.Name = "Orxan";
            student = new Student();
            student.Name = "Ceyhun";
            student.Age = 27;
            student.Point = 78.5;

            #region Reason of NullReferanceException
            student.ClassRoom = new ClassRoom();
            var studentClassNumber = student.ClassRoom.Number;
            #endregion


            #region Assign one Referance Type to another
            Student otherStudent = new Student();
            otherStudent.Name = "Babek";
            otherStudent.Age = 29;
            otherStudent.Point = 74.6d;

            student = otherStudent;

            student.Name = "Hikmet";
            #endregion
            #endregion

            #region String helper methods
            string employee = "Orkhan Farajov";
            string upperCase = employee.ToUpper();
            string lowerCase = employee.ToLower();
            string partOfString = employee.Substring(2, 4);
            #endregion



            #region What is Data Type
            string oneString = "1";
            int oneInteger = 1;

            string aString = "a";
            //int aInteger = "a";

            //Byte hesablama düsturu:
            //1 byte = 8 bit

            //Int16 tipi 16 bit'dir. - 16 bit / 8 bit = 2 byte
            //Int32 tipi 32 bit'dir. - 32 bit / 8 bit = 4 byte
            //Int64 tipi 64 bit'dir. - 64 bit / 8 bit = 8 byte

            /*
              Value-Type data tipləri:
                bool
                byte
                char
                decimal
                double
                enum
                float
                int
                long
                sbyte
                short
                struct
                uint
                ulong
                ushort

              Referance-Type data tipləri:
                String
                Arrays
                Class
                Delegate

            //Not: Referance-Type data tiplərinin default (varsayılan) dəyəri hər zaman NULL olur!
             */
            #endregion




            #region Practice with data types

            #region Boolean Type
            //həcmi: 1 bit
            //dəyər aralığı: true --- false
            //tipi: Value-Type

            bool booleanVar = true;
            booleanVar = false;

            bool otherBooleanVar;
            otherBooleanVar = true;

            string falseString = bool.FalseString;
            string trueString = bool.TrueString;
            #endregion


            #region String Type
            //həcmi: hər bir xarakter üçün 1 byte
            //tipi: Referance-Type

            string name_ = "Orkhan";
            Console.WriteLine(name_);

            string surname_ = "Farajov";
            Console.WriteLine(surname_);

            string nameSurname = "teymur jafarov";

            string upperNameSurname = nameSurname.ToUpper();
            string lowerNameSurname = nameSurname.ToLower();
            string substring = nameSurname.Substring(1, 5);
            bool startsWith = nameSurname.StartsWith("t");
            bool endsWith = nameSurname.EndsWith("t");
            int length = nameSurname.Length;
            int indexOf = nameSurname.IndexOf("y");
            bool equals = nameSurname.Equals("teymur jafarov");
            #endregion


            #region Short, Int, Long Types
            //həcmi:
                //int16: 2 byte
                //int32: 4 byte
                //int64: 8 byte

            //ala bildiyi dəyər aralığı:
                //int16: -32768 --- 32767
                //int32: −2147483648 --- 2147483647
                //int64: −9,223,372,036,854,775,808 --- 9,223,372,036,854,775,807

            //tipi: Value-Type

            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;
            short shortValue = 18262;
            short shortValueNegative = -1562;

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;
            int intValue = 256455645;
            int intValueNegative = -15645456;

            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;
            long longValue = 84564156415645645;
            long longValueNegative = -95884156415645645;

            string intToString = intValue.ToString();
            #endregion



            #region Task in Lesson 1
            /*
              10, 20
              a, b
              c
             */
            int aNumber = 10;
            int bNumber = 20;
            int cSum = aNumber + bNumber;
            #endregion


            #region Task in Lesson 2
            /*
             aze - Azerbaijan
             tur - Turkey
             azeTur Azerbaijan Turkey
             */
            string aze = "Azerbaijan";
            string tur = "Turkey";
            string azeTur = aze + " " + tur;
            #endregion



            #region Char Type
            //həcmi: 2 byte
            //tipi: Value-Type

            string a = "A";
            string b = "B";
            string c = "C";
            string d = "D";
            string e = "E";
            string f = "F";

            char charA = 'A';
            char charB = 'B';
            char charC = 'C';
            char charD = 'D';
            char charE = 'E';
            char charF = 'F';
            char symbol = '*';
            char whiteSpace = ' ';
            char question = '?';

            char toLower = char.ToLower(charA);
            char toUpper = char.ToUpper(charA);
            bool isLower = char.IsLower(toLower);
            bool isUpper = char.IsUpper(toUpper);

            bool isNumber = char.IsNumber(charA);
            bool isLetter = char.IsLetter(charA);
            bool isDigit = char.IsDigit(charA);
            bool isWhiteSpace = char.IsWhiteSpace(whiteSpace);
            #endregion



            #region Byte Type
            //həcmi: 1 byte
            //dəyər aralığı: 0-255
            //tipi: Value-Type

            byte byteVariable = 45;
            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;
            #endregion



            #region Double Type
            //həcmi: 8 byte
            //precision: 15-16 rəqəm
            //dəyər aralığı: -1.7976931348623157E+308 --- 1.7976931348623157E+308
            //tipi: Value-Type

            double doubleVar = 10.2;
            double doubleVar2 = 25;
            double doubleVar3 = 45.8d;

            double nan = 0.0 / 0.0;
            double notNan = 5 / 2.5;
            bool resultOfNan = double.IsNaN(nan);
            bool resultOfNotNan = double.IsNaN(notNan);

            double infinity = 0.1 / 0.0;
            double notInfinity = 0.0 / 0.0;
            bool resultOfInfinity = double.IsInfinity(infinity);
            bool resultOfNotInfinity = double.IsInfinity(notInfinity);

            double epl = double.Epsilon;
            double epsilonValue = 4.94065645841247E-324;
            double one = 0.1;

            bool whichIsGreater = one > epsilonValue;
            #endregion


            #region Decimal Type
            //həcmi: 16 byte
            //precision: 28-29 rəqəm
            //dəyər aralığı: -79228162514264337593543950335M --- 79228162514264337593543950335M
            //tipi: Value-Type

            decimal decimalVar = 10.2m;

            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;

            //byte decimalToByte = decimal.ToByte(1000000000);
            //sbyte decimalToSByte = decimal.ToSByte(1000000000);

            short decimalToShort = decimal.ToInt16(500);
            int decimalToInt = decimal.ToInt32(222515);
            long decimalToLong = decimal.ToInt64(548945941894151);
            #endregion


            #region Float Type
            //həcmi: 4 byte / 32 bit
            //precision: 7 rəqəm
            //dəyər aralığı: -3.40282347E+38F --- 3.40282347E+38F
            //tipi: Value-Type

            float floatVar = 10.2f;
            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;
            #endregion


            #region DateTime Type
            //həcmi: 8 byte
            //dəyər aralığı: 1/1/0001 --- 12/31/9999
            //tipi: Value-Type

            DateTime now = DateTime.Now; //Local saatı qaytarır
            DateTime utcNow = DateTime.UtcNow; //'Universal Time Coordinate' saatı qaytarır

            long ticks = now.Ticks;
            int millisecond = now.Millisecond;
            int second = now.Second;
            int minute = now.Minute;
            int hour = now.Hour;
            int day = now.Day;
            DayOfWeek dayOfWeek = now.DayOfWeek;
            int month = now.Month;
            int year = now.Year;
            TimeSpan timeOfDay = now.TimeOfDay;
            string shortDateString = now.ToShortDateString();
            string longDateString = now.ToLongDateString();
            string shortTimeString = now.ToShortTimeString();
            string longTimeString = now.ToLongTimeString();
            string timeFormat = now.ToString("MM/dd/yyyy HH:mm:ss");
            string timeFormat2 = now.ToString("MMMM dd");
            string timeFormat3 = now.ToString("dddd, dd MMMM yyyy");
            string timeFormat4 = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            string timeFormat5 = now.ToString("HH:mm");
            string timeFormat6 = now.ToString("H:mm");
            string timeFormat7 = now.ToString("ddd, dd MMM yyy HH:mm:ss");

            DateTime monthChanged = now.AddMonths(2);
            DateTime dayChanged = now.AddDays(2);
            DateTime hourChanged = now.AddHours(4);
            DateTime minuteChanged = now.AddMinutes(15);
            DateTime secondChanged = now.AddSeconds(5);
            string changedTime = hourChanged.ToString("HH:mm");

            DateTime specificDate = new DateTime(1990, 12, 25);
            DateTime specificDateAndTime = new DateTime(1995, 12, 24, 10, 05, 59, 100/*millisecond*/);
            #endregion
            #endregion
        }
    }
}
