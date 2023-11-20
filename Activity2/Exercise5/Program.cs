namespace Exercise5;

internal class Exercise5
{
    public static void Main()
    {
        List<string?> countries = new List<string?>();
        
        while (true)
        {
            Console.Write("Country: ");
            string? input = Console.ReadLine();

            if (input == "STOP")
            {
                PrintLongCountries(countries, 8);
                return;
            }
            countries.Add(input);
        }
    }

    private static void PrintLongCountries(List<string?> countries, int limit)
    {
        Console.WriteLine();
        foreach (string? country in countries)
        {
            if (country != null && country.Length < limit) continue;
            
            string c = $"Country: {country}".PadRight(25);
            Console.WriteLine($"{c} | Length: {country.Length}");
        }        
    }
    
}