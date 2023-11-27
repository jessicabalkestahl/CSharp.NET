
namespace ConsoleAppProj52
{
    public class Program
    {
        private static void Main()
        {
            Car car1 = new("Ford", "Focus", 2018, "AG-88-10", "Blue");
            Car car2 = new("Renault", "Megane", 2020, "AF-77-11", "White");
            Car car3 = new("Bmw", "320D", 2021, "AG-88-10", "Black");
            
            car1.PrintCarInfo();
            car2.PrintCarInfo();
            car3.PrintCarInfo();
            
            Console.WriteLine($"Start car 1: {car1.Brand} {car1.Model} from the year {car1.Year} with the plate number " +
                              $"{car1.PlateNumber} ({car1.Colour}) {car1.Start()}");
            Console.WriteLine($"Stop car 2 : {car2.Brand} {car2.Model} from the year {car2.Year} with the plate number " +
                              $"{car2.PlateNumber} ({car2.Colour}) {car1.Stop()}");
            Console.WriteLine();
            
            Console.WriteLine($"Does car 1 equals car 2? {car1.Equals(car2)}");
            Console.WriteLine($"Does car 2 equals car 3? {car2.Equals(car3)}");
            Console.WriteLine($"Does car 1 equals car 3? {car3.Equals(car1)}");

            Console.WriteLine();
            Console.WriteLine($"Total number of cars: {Car.TotalNumberOfCars}");
            
            
        }
    }
}