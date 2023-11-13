namespace Exercise2
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Enter the first integer: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third integer: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("The highest number is: {0}", GetHighestNumber(number1, number2, number3));
        }

        private static long GetHighestNumber(int number1, int number2, int number3)
        {
            int[] numbers = { number1, number2, number3 };
            return numbers.Max();
        }
    }
}