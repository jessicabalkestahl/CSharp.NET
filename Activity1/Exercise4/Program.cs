
namespace Exercise4
{
    internal static class Program
    {
        private static void Main()
        {
            MultiplyEvenNumbers();
            AddOddNumbers();
        }

        private static long MultiplyEvenNumbers()
        {
            long even = 1;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 != 0) continue;
                
                even *= i;
            }
            Console.WriteLine($"[Even numbers multiplication] {even}");
            return even;
        }
        
        private static int AddOddNumbers()
        {
            int odd = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0) continue;

                odd += i;
            }

            Console.WriteLine($"[Odd numbers addition] {odd}");
            return odd;
        }
    }
}