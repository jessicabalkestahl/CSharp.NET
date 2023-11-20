using System.Globalization;

namespace Exercise6;

internal class Exercise6
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("Insert a number between 10 and 100: ");
            double number = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number is < 10 or > 100)
            {
                return;
            }
            
            double squareRoot = Math.Sqrt(number);
            if (squareRoot > 5)
            {
                Console.WriteLine($"Square root of {number}: {Math.Round(squareRoot, 2)}");
            }
        }
    }

    
}