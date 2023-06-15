using PartialClass_Enum.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Id = 1;
            book.CreateDate = DateTime.Now;
            book.CreateUser = 100;
            book.Code = 123456789;
            book.Genre = "SomeGenre";
            book.Publisher = "SomePublisher";
            book.Cover = "SomeCover";
            book.Author = "SomeAuthor";
            book.Page = 500;
            book.Language = "ENG";

            book.Add(book);
            book.Update(book);
            book.Delete(1);

            Car car = new Car();
            car.Id = 1;
            car.CreateDate = DateTime.Now;
            car.Brand = "Mercedes";
            car.Model = "GL500";
            car.Year = 100;
            car.SeatCount = 100;
            car.SeatMaterial = "...";
            car.Door = 100;
            car.Engine = 100;
            car.FuelType = "...";

            Person person = new Person();
            person.Name = "Orkhan";
            person.Surname = "Farajov";
            person.Gender = GenderEnum.Male;
            //person.GenderInteger = 1;

            person.GenderInteger = (int)GenderEnum.Male;

            if(person.Gender == GenderEnum.Male)
                Console.WriteLine("Person is Male");
            else
                Console.WriteLine("Person is Female");

            if (person.Gender.Equals(GenderEnum.Male))
                Console.WriteLine("Person is Male");
            else
                Console.WriteLine("Person is Female");

            if (person.GenderInteger == (int)GenderEnum.Male)
                Console.WriteLine("Person is Male");
            else
                Console.WriteLine("Person is Female");
        }
    }
}
