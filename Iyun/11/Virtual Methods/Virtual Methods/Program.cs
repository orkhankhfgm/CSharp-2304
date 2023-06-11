using System;

namespace Virtual_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region General
            Customer customer = new Customer();
            var tostring = customer.ToString(); //Virtual_Methods.Customer
            Console.WriteLine(tostring);

            customer.Name = "Orkhan";
            customer.Surname = "Farajov";
            tostring = customer.ToString();
            Console.WriteLine(tostring);

            Item item = new Item();
            item.ShowText("Hello");

            BaseClass baseClass = new BaseClass();
            baseClass.ShowText("Hello");
            #endregion
        }
    }
}
