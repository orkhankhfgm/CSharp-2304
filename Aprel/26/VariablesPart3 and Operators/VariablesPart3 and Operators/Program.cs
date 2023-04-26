using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesPart3_and_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            //Boxing
            //Implicit
            int valueType = 55;
            object referanceType = valueType;

            //Explicit
            object otherRefType = (object)valueType;

            //Unboxing
            int a = 100;
            object o = a;
            int unboxing = (int)o;

            int b = 100;
            object o1 = b;
            //int err = (byte)o1;
            #endregion

            #region Convert, Parse and TryParse
            string textNumber = "100";

            //with convert
            int convertToInt = Convert.ToInt32(textNumber);

            //with parse method
            int parseToInt = int.Parse(textNumber);

            //with try parse method
            int integerValue;

            string notNumberString = "5Salam";
            bool badResult = int.TryParse(notNumberString, out integerValue);

            string numberString = "5";
            bool goodResult = int.TryParse(numberString, out integerValue);


            #region Task in Lesson 1
            //1. bool tipinde deyisen yaradin deyeri de true olsun.
            //2. int tipinde deyiseniniz olsun ve deyeri 1 olsun.
            bool booleanVar = true;
            int resultOfTryParse = 1;
            string stringVar = booleanVar.ToString();

            bool parse = int.TryParse(stringVar, out resultOfTryParse);
            int result = Convert.ToInt32(booleanVar);
            #endregion

            string nullString = null;
            int nullConvertResult = Convert.ToInt32(nullString); //default value gelecek
            //int nullParseResult = int.Parse(nullString); //error
            int nullOutVal = 2;
            bool tryToParseNull = int.TryParse(nullString, out nullOutVal);

            string notString = "A";
            //int notIntConvertResult = Convert.ToInt32(notString); //error
            //int notIntParseResult = int.Parse(notString); //error
            int notIntOutVal = 2;
            bool tryToParsenotInt = int.TryParse(notString, out notIntOutVal);
            #endregion

            #region Task in Lesson 2
            /*
             Task 1: İki dənə int tipində dəyişəniniz olacaq. Birinin dəyəri 1, digərinin dəyəri 0 olacaq.
                     Sonra bu iki int tipindən başqa boolean tipində 2 dəyişəniniz olacaq. Bu iki int
                     tipində olan dəyişəninizi digər iki boolean tipində dəyişənə çevirəcəksiz.
             */
            int falseVal = 0;
            int trueVal = 1;

            bool falseBool = Convert.ToBoolean(falseVal);
            bool trueBool = Convert.ToBoolean(trueVal);

            /*
             Task 2: Bir dənə DateTime tipində dəyişəniniz olsun və indiki zamanı götürün. Sonra o dəyişəni
                     bir başqa object tipindəki dəyişənə mənimsədin. Yəni Boxing. Sonra DateTime tipində
                     3-cü bir dəyişən yaradın və 2-ci yaratdığınız object'in dəyərini 3-cü yaratdığınız 
                     DateTime tipində olan dəyişənə verin.
             */

            DateTime now = DateTime.Now;
            object objDate = now;
            var dateFromObject = Convert.ToDateTime(objDate);
            
            /*
             Task 3: İki string tipində dəyişəndə True və False sözlərini saxlayın. Sonra bu string'ləri bool
                     tipində bir dəyişənə çevirin. Convert'dən istifadə etmək olmaz.
             */
            string trueText = "True";
            string falseText = "False";

            bool trueFromText = bool.Parse(trueText);
            bool falseFromText = bool.Parse(falseText);
            #endregion


            #region Constant
            double pi = 3.14;
            //bir ay kecdi

            pi = 5.20;

            const double piConst = 3.14;
            //piConst = 5;

            int no; //burada teyin edirem
            no = 100; //burada ise deyerini verirem

            decimal dec;
            dec = 45.7m;

            string name;
            name = "Orkhan";

            DateTime dt;
            dt = DateTime.Now;

            //const int aa; deyer vermeden teyin etmek olmur
            const int number = 500;
            //const int buildingNo = no;
            const int buildingNo = number;
            #endregion


            #region Var keyword
            int numberVar = 1;
            string textVar = "Hello";
            decimal decimalVar = 5.60m;
            double doubleVar = 48.5;
            DateTime dateTimeVar = DateTime.Now;
            char charVar = 'R';
            long londVar = 97849849489498489;
            short shortVar = 100;

            var numberVarKeyword = 1;
            var textVarKeyword = "Hello";
            var decimalVarKeyword = 5.60m;
            var doubleVarKeyword = 48.5;
            var dateTimeVarKeyword = DateTime.Now;
            var charVarKeyword = 'R';
            var londVarKeyword = 97849849489498489;
            var shortVarKeyword = 100;

            var i1 = 100;
            //i1 = "Salam";

            var dbl = 100.2;
            //dbl = DateTime.Now;

            var dtt = DateTime.Now;
            //dtt = 5;

            //type inferance
            //IL = Intermediate Language

            object objectVariable = 50;
            objectVariable = "string data";
            objectVariable = 45.1;
            objectVariable = true;


            int seeIntMethods = 5;
            string seeStringMethods = "salam";
            object obj = seeIntMethods;
            object obj1 = seeStringMethods;

            int number1, number2, otherNumber;
            string firstname, surname, fatherName, birthPlace;
            DateTime startDate, endDate;
            int no1 = 50, no2 = 30, no3 = 40;
            string city = "Baku", country = "Azerbaijan", postCode = "AZ1000";
            #endregion


            #region Operators
            /*
             1. Unary: a++, b--, !true
             2. Binary: a + b, a > b, a = b
             3. Ternary a > b ? "" : ""
             Operand nedir?: a, b, c ve umumen deyisenler ve deyerler

             1. Arithmetic (hesablama)       ++, --, +, -, *, /, %
             2. Logical    (məntiqi)         !, ||, &&
             3. Special    (xüsusi)          sizeof, typeof, new, checked, unchecked, as, is
             4. Assignment (mənimsəmə)       =, +=, -=, /=, *=, %=
             5. Comparsion (qarşılaşdırma)   >, <, ==, !=, <=, >=
             */

            decimal x = 100;
            decimal y = 5;
            decimal i = 0;

            //Arithmetic (hesablama)
            i = x + y;
            i = x - y;
            i--;
            i++;
            i = i + 1;
            i = i - 1;
            i -= 5;
            i += 5;
            i = x * y;
            i = x / y;
            i = x % y;
            int m = 10 % 2;
            m = 11 % 2;
            string countryOfResidence = "Azerbaijan";
            string cityOfResidence = "Baku";
            string address = countryOfResidence + " " + cityOfResidence;

            //Logical (məntiqi)
            bool trueBoolean = true, falseBoolean = false, res;
            res = !trueBoolean;
            res = !falseBoolean;
            res = !falseBoolean || !trueBoolean;
            res = !falseBoolean && !trueBoolean;
            res = 4 > 6 || 5 == 10;
            res = 4 > 6 && 5 == 10;
            res = 4 < 6 || 5 == 10;
            res = 4 < 6 && 5 == 10;
            res = 5 == 5;

            //Assignment (mənimsəmə)
            int assign = 100;
            assign += 5;
            assign -= 5;
            assign *= 5;
            assign /= 5;
            assign %= 5;
            string person = "Orkhan Farajov";
            person += " is developer";

            //Comparsion (qarşılaşdırma)
            int c = 100;
            int d = 5;
            string name1 = "Orkhan";
            string name2 = "Samir";

            bool compareResult = false;
            compareResult = c > d;
            compareResult = c < d;
            compareResult = c == d;
            compareResult = c != d;
            compareResult = c <= d;
            compareResult = c >= d;
            compareResult = name1 == name2;
            compareResult = name1 != name2;
            short e = 15;
            compareResult = e == c;
            compareResult = (10 / 2) == 5;
            compareResult = (10 / 2) != 5;


            //Special (xüsusi) ------ sizeof, typeof, new, checked, unchecked, as, is
            int sizeOfSbyte = sizeof(sbyte); //1 byte
            int sizeOfbyte = sizeof(byte); //1 byte
            int sizeOfInt16 = sizeof(Int16); //2 byte
            int sizeOfShort = sizeof(short); //2 byte
            int sizeOfInt32 = sizeof(Int32); //4 byte
            int sizeOfInt = sizeof(int); //4 byte
            int sizeOfInt64 = sizeof(Int64); //8 byte
            int sizeOfLong = sizeof(long); //8 byte
            int sizeOfUInt = sizeof(uint); //4 byte
            int sizeOfBool = sizeof(bool); //1 byte

            //int sizeOfString = sizeof(string); //sizeof ile, referance type'larin olcusunu check etmek olmur. Run-time zamani belli olur.

            Type type1 = typeof(int);
            Type type2 = typeof(Int32);
            bool compareIntAndInt32 = type1 == type2;

            Type type3 = typeof(int);
            Type type4 = typeof(bool);
            bool compareIntAndBoolean = type3 == type4;

            DateTime dtToday = new DateTime();

            //is
            int otherInt = 25;

            bool isOtherInt_String = otherInt is string;
            bool isOtherInt_Int = otherInt is int;
            bool isOtherInt_Int32 = otherInt is Int32;
            bool isOtherInt_Boolean = otherInt is Boolean;

            //as
            object objectName = "Orkhan";
            object objectNum = 5;
            string sName = objectName as string;
            string sText = objectNum as string; //null
            //int aaa = sName as int;

            float u = 10 + 20 * 5; //110
            float u1 = (10 + 20) * 5; //150;
            #endregion


            #region Extra
            var z = 250;
            z--;

            var v = 250;
            --v;

            var k = 250;
            var getK = k--;

            var p = 250;
            var getP = --p;
            #endregion
        }
    }
}
