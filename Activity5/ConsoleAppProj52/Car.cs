namespace ConsoleAppProj52
{
    internal class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public string? Colour { get; set; }
        
        public static int TotalNumberOfCars { get; private set; }

        public string Start()
        {
            return "started the car and initiated the trip.";
        }
        
        public string Stop()
        {
            return "stoped and turned off the car.";
        }

        public Car(string plateNumber)
        {
            this.PlateNumber = plateNumber;
            IncrementTotalNumberOfCars();
        }

        public Car(string? brand, string? model, int year, string plateNumber, string? colour)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = plateNumber;
            this.Colour = colour;

            IncrementTotalNumberOfCars();
        }

        private static int IncrementTotalNumberOfCars()
        {
            TotalNumberOfCars++;

            return TotalNumberOfCars;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Brand       : {this.Brand}");
            Console.WriteLine($"Model       : {this.Model}");
            Console.WriteLine($"Year        : {this.Year}");
            Console.WriteLine($"Plate Number: {this.PlateNumber}");
            Console.WriteLine($"Colour      : {this.Colour}\n");
        }

        public bool Equals(Car car)
        {
            return this.PlateNumber == car.PlateNumber;
        }
    }
}