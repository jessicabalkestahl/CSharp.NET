using System;

namespace ExceptionProj1
{
    internal static class Program
    {
        private static void Main()
        {
            SumNumbers();
        }

        private static void SumNumbers()
        {
            try
            {
                int firstNumber, secondNumber, sum = 0;
                Console.Write("First number: ");
                firstNumber = int.Parse(Console.ReadLine()!);
                Console.Write("Second number: ");
                secondNumber = int.Parse(Console.ReadLine()!);

                sum = firstNumber + secondNumber;
                Console.WriteLine($"Sum: {sum}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("An error has occured! Use integers as in your inputs.");
                Console.WriteLine($"Error message: {e.Message}");
                Console.WriteLine("Enter any key to continue ...");
                Console.ReadKey();
                Console.Clear();
                SumNumbers();
            }
        }
    }
}


