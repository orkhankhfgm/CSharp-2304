using PartialClass_Enum.Enums;
using System;

namespace PartialClass_Enum
{
    public class Person : BaseClass<Person>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public int GenderInteger { get; set; }

        public override Person Get(int id)
        {
            return new Person();
        }

        public override Person[] GetAll()
        {
            return new Person[10];
        }

        public override int Add(Person book)
        {
            return 1;
        }

        public override Person Update(Person book)
        {
            return new Person();
        }

        public override bool Delete(int id)
        {
            return true;
        }
    }
}
