namespace PartialClass_Enum
{
    public partial class Car : BaseClass<Car>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int SeatCount { get; set; }
        public string SeatMaterial { get; set; }
        public int Door { get; set; }
        public int Engine { get; set; }
        public string FuelType { get; set; }

        public override Car Get(int id)
        {
            return new Car();
        }

        public override Car[] GetAll()
        {
            return new Car[10];
        }

        public override int Add(Car book)
        {
            return 1;
        }

        public override Car Update(Car book)
        {
            return new Car();
        }

        public override bool Delete(int id)
        {
            return true;
        }
    }
}
