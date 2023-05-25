using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            //HomeworkLocalFunctions.Calculate1("10", "20", "+");



            Vehicle vehicle = new Vehicle("Mercedes-Benz", "ML350", 2010, 20000);
            vehicle.BuyPrice = 15000;
            vehicle.SellPrice = 20000;
            vehicle.MaxDiscount = 1500;

            vehicle.SetPrice(16000);
            vehicle.ShowVehicleInfo();
        }
    }
}
