using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is NOT Generic Class
            Customer customer = new Customer();

            //T yerinə bir tip ötürülməsə xəta verəcək!
            //CustomerGeneric genericClass = new CustomerGeneric();

            CustomerGeneric<string> gCustomer = new CustomerGeneric<string>();
            gCustomer.Id = 5;
            gCustomer.Name = "Orkhan";
            gCustomer.Surname = "Farajov";
            gCustomer.DateOfBirth = new DateTime(1995, 12, 24);
            gCustomer.DocumentNo = "123456";
            gCustomer.DocumentSerial = "AA";
            gCustomer.PlaceOfBirth = "Baku";



            MultipleGenericClass<string, int, DateTime> multiGeneric = new MultipleGenericClass<string, int, DateTime>();
            gCustomer.Id = 5;
            gCustomer.Name = "Orkhan";
            gCustomer.Surname = "Farajov";
            gCustomer.DateOfBirth = new DateTime(1995, 12, 24);

            MultipleGenericClass<decimal, bool, char> test = new MultipleGenericClass<decimal, bool, char>();
            test.Id = true;
            test.Name = 15;
            test.Surname = 15;
            test.DateOfBirth = 'Y';

            string name = multiGeneric.GetName();
            #endregion



            #region What is Generic Class
            //Database      |     App
            //MsSQL         |     C#/.NET Core

            GenericRepository<Customer> customerRepository = new GenericRepository<Customer>();
            List<Customer> customers = customerRepository.Get();

            GenericRepository<Item> itemRepository = new GenericRepository<Item>();
            List<Item> items = itemRepository.Get();

            Customer cust = new Customer();
            Item item = new Item();

            customerRepository.Add(cust);
            itemRepository.Add(item);

            //GenericRepository<int> intRepo = new GenericRepository<int>();
            #endregion
        }
    }
}
