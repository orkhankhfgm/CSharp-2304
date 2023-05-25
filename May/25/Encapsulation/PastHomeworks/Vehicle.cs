using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomeworks
{
    public class Vehicle
    {
        /*
            Satılacaq məhsulu yaradacaqsınız və onun bir neçə dənə constructor method'ları olacaq.

            Məhsul (item) Class'ında olacaq property'lər:
                Marka
                Model
                İstehsal ili
                Km
                Yanacaq növü
                Sürətlər qutusu
                Alış qiyməti
                Satış qiyməti
                Max endirim məbləği
                Qiymət (private olması mütləqdir!)

            Constructor overload'ları aşağıdakı kimi olmalıdır:
                1. marka, model
                2. marka, model, istehsal ili
                3. marka, model, istehsal ili, km
                4. bütün property'lər

            Əlavə olaraq iki methodunuz olacaq hansı ki, birinci method bütün məlumatları ekrana yazacaq və ikinci method isə müəyyən obyektin
            satış qiymətini təyin edəcək. Burda biraz baş işlətmək lazımdır. Təyin edilən qiymət, satış qiyməti - max endirim qiyməti qədər
            olmalıdır. Yəni, max endirim qiyməti qədər geriyə gedə bilməliyəm.
            Məsələn:
            Satış qiymətim 10 manatdırsa, maximum endirim qiymətim 2 manatdırsa, mən bu məhsulu ən aşağı 8 manata sata bilməliyəm. 7 manata
            satmağa çalışsam xəta mesajı yazsın ekrana (məs: Max. endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!)
       */

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal KmUsed { get; set; }
        public int FuelType { get; set; }
        public int TransmissionType { get; set; }
        public decimal BuyPrice { get; set; } //10000
        public decimal SellPrice { get; set; } //8000
        public decimal MaxDiscount { get; set; } //2000
        private decimal Price { get; set; } //8000

        public Vehicle()
        {

        }

        public Vehicle(string _brand, string _model)
        {
            Brand = _brand;
            Model = _model;
        }

        public Vehicle(string _brand, string _model, int _year)
        {
            Brand = _brand;
            Model = _model;
            Year = _year;
        }
        
        public Vehicle(string _brand, string _model, int _year, decimal KmUsed)
        {
            Brand = _brand;
            Model = _model;
            Year = _year;
            //KmUsed = KmUsed //(eyni dəyişəni eyni dəyişənə mənimsədir)
            this.KmUsed = KmUsed; //(Burada this Class'ı təmsil)
        }

        public void ShowVehicleInfo()
        {
            Console.WriteLine("Brand: {0} - Model: {1} - Year: {2} - Price: {3}",
                Brand, Model, Year, Price);
        }

        public void SetPrice(decimal _price)
        {
            decimal calcMinPrice = SellPrice - MaxDiscount;

            if (_price < calcMinPrice)
                Console.WriteLine("Price can't update!");
            else
            {
                this.Price = _price;
                Console.WriteLine("Price updated!");
            }
        }
    }
}
