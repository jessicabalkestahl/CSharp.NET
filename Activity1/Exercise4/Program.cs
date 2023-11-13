
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
                
                long result = even * i;
                Console.WriteLine("[Even {0}] {1} * {0} = {2}", i, even, result);
                even = result;
            }
            return even;
        }
        
        private static int AddOddNumbers()
        {
            int odd = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0) continue;
                
                int result = odd + i;
                Console.WriteLine("[Odd {0}] {1} + {0} = {2}", i, odd, result);
                odd = result;
            }
            return odd;
        }
    }
}