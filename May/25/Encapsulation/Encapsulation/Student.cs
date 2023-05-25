﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Student
    {
        #region What is Encapsulation
        public string Name;
        public string Surname;
        private string email;

        public string Email
        {
            set
            {
                if (value.Length > 15)
                    this.email = value;
                else
                    this.email = "default@gmail.com";
            }
            get
            {
                return this.email;
            }
        }
        #endregion


        #region Id Generator
        int id;

        public int Id
        {
            private set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }

        public Student()
        {
            this.Id = GenerateId();
        }

        private int GenerateId()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999);
        }
        #endregion

        #region Task in Lesson 1
        /*
            Vəsiqənin seriyası və vəsiqənin nömrəsi adlı iki xananız olacaq. DocumentSerial və DocumentNumber olaraq adlandıra bilərsiniz.
            Hər biri üçün, getter və setteri olan bir property'si və private bir field'ı olacaq.
            Validation və xəta mesajları:
            Vəsiqənin seriyasını set edən zaman yoxlamalıdır ki, uzunluğu 2 hərfdir mi?
            Deyilsə: "Vesiqenin seriyasinin uzunlugu 2 herf olmalidir!" xətası çıxmalıdır.
            Eyni zamanda yoxlamalıdır ki, sadəcə hərflərdən mi ibarətdir?
            Deyilsə: "Vesiqenin seriyasi sadece herflerden ibaret olmalidir!" xətası çıxmalıdır.
            Eyni zamanda da, vəsiqənin nömrəsi set olunan zaman baxmalıdır ki, uzunluğu 8 ə bərabərdir mi?
            Deyilsə: "Vesiqenin nomresinin uzunlugu 8 olmalidir!" xətası çıxmalıdır.
            Birdə nömrənin rəqəmlərdən ibarət olub-olmaması yoxlanmalıdır.
            Deyilsə: "Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!" xətası çıxacaq.
            Bu validation'lara əlavə olaraq vəsiqənin nömrəsi get olan zaman ancaq ilk 3 rəqəm user'ə göstəriləcək. Digər rəqəmlər ulduz
            simvolu olaraq çıxacaq. Orda elə etmək lazımdır ki, 3 və ulduz sayı dinamik olsun. Yəni mən 3 rəqəmini 4 edən zaman avtomatik
            4 simvol görsənsin və geri qalan 4 simvol ulduz çıxsın. Əgər 3 rəqəmini 6 etsəm o zaman ilk 6 rəqəm görsənsin və 2 simvol ulduz
            olaraq çıxsın.
            Vaxt: 15 dəqiqə
         */


        private string _documentSerial;
        public string DocumentSerial
        {
            get
            {
                return _documentSerial;
            }
            set
            {
                if (value.Length == 2)
                {
                    bool checkResult = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharacter = !char.IsLetter(value[i]);
                        if (badCharacter)
                        {
                            checkResult = true;
                            break;
                        }
                    }

                    if (checkResult)
                        Console.Write("Vesiqenin seriyasi sadece herflerden ibaret olmalidir!");
                    else
                        this._documentSerial = value;
                }
                else
                {
                    Console.WriteLine("Vesiqenin seriyasinin uzunlugu 2 olmalidir!");
                }
            }
        }

        private string _documentNumber;
        public string DocumentNumber
        {
            get
            {
                var length = _documentNumber.Length;
                var showFirstNLetter = 6;
                var hiddenString = "";

                for (int i = 0; i < (length - showFirstNLetter); i++)
                {
                    hiddenString += "*";
                }

                return _documentNumber.Substring(0, showFirstNLetter) + hiddenString;
            }
            set
            {
                if (value.Length == 8)
                {
                    bool checkResult = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharacter = !char.IsNumber(value[i]);
                        if (badCharacter)
                        {
                            checkResult = true;
                            break;
                        }
                    }

                    if (checkResult)
                        Console.Write("Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!");
                    else
                        this._documentNumber = value;
                }
                else
                {
                    Console.WriteLine("Vesiqenin nomresinin uzunlugu 8 olmalidir!");
                }
            }
        }
        #endregion
    }
}
