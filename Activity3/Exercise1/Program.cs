
namespace Exercise1;

internal static class Exercise1
{
    private static readonly string[] EuropeanCapitals = { "Lisbon", "Berlin", "Rome", "Paris", "London", "Bern", "Amsterdam", "Madrid" };
    
    public static void Main()
    {
        PrintFile("capitals.txt");
        PrintEuropeanCapitals("capitals.txt");
        GetTotalNumberOfCapitals("capitals.txt");
        PrintNonEuropeanCapitals("capitals.txt", "nonEuropeanCapitals.txt");
    }

    private static void PrintFile(string fileName)
    {
        Console.WriteLine("\n===== Print all capitals =====\n");
        List<string>? capitals = GetCapitalsFromFile(fileName);

        if (capitals == null) return;
        
        foreach (string capital in capitals)
        {
            Console.WriteLine(capital);
        }
    }

    private static void PrintEuropeanCapitals(string fileName)
    {
        Console.WriteLine("\n===== Print european capitals =====\n");

        List<string>? capitals = GetCapitalsFromFile(fileName);

        if (capitals == null) return;
        
        foreach (string capital in capitals)
        {
            string? result = Array.Find(EuropeanCapitals, element => element == capital);

            if (result == null) continue;
            
            Console.WriteLine(capital);
        }
        
    }

    private static void GetTotalNumberOfCapitals(string fileName)
    {
        Console.WriteLine("\n===== Print total number of capitals =====\n");
        try
        {
            List<string>? capitals = GetCapitalsFromFile(fileName);

            if (capitals == null) return;
            
            Console.WriteLine($"The total number of capitals in the {fileName} is {capitals.Count}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong and couldn't get the total number of capitals.");
            Console.WriteLine(e.Message);
        }
    }
    
    private static void PrintNonEuropeanCapitals(string fileName, string newFileName)
    {
        Console.WriteLine("\n===== Print non-european capitals =====\n");

        try
        {
            using StreamWriter sw = new(newFileName);
            List<string>? capitals = GetCapitalsFromFile(fileName);

            if (capitals == null) return;
            
            foreach (string capital in capitals)
            {
                string? result = Array.Find(EuropeanCapitals, element => element == capital);
                
                if (result != null) continue;
                
                sw.WriteLine(capital);
                Console.WriteLine(capital);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong and couldn't get the non-european capitals.");
            Console.WriteLine(e.Message);
        }
    }

    private static List<string>? GetCapitalsFromFile(string fileName)
    {
        try
        {
            using StreamReader sr = new(fileName);
            List<string>? capitals = new();

            while (sr.ReadLine() is { } line)
            {
                capitals.Add(line);
            }

            return capitals;
        }
        catch (Exception e)
        {
            Console.WriteLine("Couldn't get capitals from file.");
            Console.WriteLine(e.Message);

            return null;
        }
    }

    
}