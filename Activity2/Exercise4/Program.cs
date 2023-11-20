namespace Exercise4;

internal class Exercise4
{
    public static void Main()
    {
        Console.WriteLine("=== First array ===");
        int[] firstArr = CreateArray();
        Console.WriteLine("=== Second array ===");
        int[] secondArr = CreateArray();

        string firstResult = PrintOddNumbers(firstArr);
        Console.WriteLine(firstResult);
        
        string secondResult = PrintEvenNumbers(secondArr);
        Console.WriteLine(secondResult);
    }

    private static int[] CreateArray()
    {
        int[] arr = new int[10];
        
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        return arr;
    }
    
    private static string PrintOddNumbers(int[] arr)
    {
        string result = "[ Array 1 - Odd numbers ]\n";
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                result += $"{arr[i]}\n";
            }
        }

        return result;
    }
    
    private static string PrintEvenNumbers(int[] arr)
    {
        string result = "[ Array 2 - Even numbers ]\n";
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                result += $"{arr[i]}\n";
            }
        }

        return result;
    }
}