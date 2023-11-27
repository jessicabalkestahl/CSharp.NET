namespace ConsoleAppActivity41;

public class TestCoordinates
{
    private static void Main()
    {

        Coordinates c1 = new();
        Coordinates c2 = new(2, -1);
        Coordinates c3 = new(0, 2);
        
        Console.WriteLine("-----> Initial coordinates <-----");
        Console.WriteLine($"Coordinate c1: ({c1.X}, {c1.Y})");
        Console.WriteLine($"Coordinate c2: ({c2.X}, {c2.Y})");
        Console.WriteLine($"Coordinate c3: ({c3.X}, {c3.Y})");
        
        c1.IncrementCoordinates(5, 10);
        c2.IncrementCoordinates(15, 4);
        c3.DecrementCoordinates(3, 8);
        
        Console.WriteLine("\n-----> Modified coordinates <-----");
        Console.WriteLine($"Coordinate c1: {c1.ToString()}");
        Console.WriteLine($"Coordinate c2: {c2.ToString()}");
        Console.WriteLine($"Coordinate c3: {c3.ToString()}");
        
        Console.WriteLine("\n-----> Sum coordinates c1 and c2 <-----");
        Console.WriteLine($"Sum of coordinates X: {c1.X + c2.X}");
        Console.WriteLine($"Sum of coordinates Y: {c1.Y + c2.Y}");
        
        Console.WriteLine("\n-----> Are the coordinates negative? <-----");
        Console.WriteLine($"Does c1 have negative coordinates? {!c1.AreCoordinatesPositive()}");
        Console.WriteLine($"Does c2 have negative coordinates? {!c2.AreCoordinatesPositive()}");
        Console.WriteLine($"Does c3 have negative coordinates? {!c3.AreCoordinatesPositive()}");
        
        Console.WriteLine("\n-----> Total number of coordinates <-----");
        Console.WriteLine($"TotalCoordinates: {Coordinates.TotalCoordinates}");
        
    }
}