namespace Exercise2
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Enter the first integer: ");
            long number1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            long number2 = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the third integer: ");
            long number3 = Convert.ToInt64(Console.ReadLine());

            Console.Write("The highest number is: {0}", GetHighestNumber(number1, number2, number3));
        }

        private static long GetHighestNumber(long number1, long number2, long number3)
        {
            long[] numbers = { number1, number2, number3 };
            return numbers.Max();
        }
    }
}