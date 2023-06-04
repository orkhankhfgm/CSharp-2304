using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                DocumentNo = 555555,
                BirthDate = DateTime.Now,
                CreateDate = DateTime.Now,
                EditDate = null
            };

            Country country = new Country()
            {
                Id = 1,
                Name = "Azerbaijan",
                CreateDate = DateTime.Now,
            };

            City city = new City()
            {
                Id = 1,
                Name = "Baku",
                Country = country,
                CreateDate = DateTime.Now
            };

            Order laptopOrder = new Order()
            {
                Id = 1,
                OrderDetails = "Asus Tuf fx705GM, 3800 usd",
                CreateDate = DateTime.Now
            };

            customer.Addresses[0] = new Address()
            {
                Id = 1,
                No = 15,
                Building = "MyBuilding",
                Street = "HomeStreet",
                Distinct = "Narimanov",
                City = city,
                CreateDate = DateTime.Now
            };

            customer.Addresses[1] = new Address()
            {
                Id = 2,
                No = 40,
                Building = "Residence",
                Street = "WorkStreet",
                Distinct = "Yasamal",
                City = city,
                CreateDate = DateTime.Now
            };

            customer.Contacts[0] = new Contact()
            {
                Id = 1,
                Email = "orkhan@mail.com",
                PhoneNumber = "+994555810872",
                CreateDate = DateTime.Now
            };

            customer.Orders[0] = new Order()
            {
                Id = 2,
                OrderDetails = "Samsung Galaxy S9+, 600 usd",
                ShippingAddress = customer.Addresses[1],
                CreateDate = DateTime.Now
            };

            customer.Orders[1] = laptopOrder;
        }
    }
}
