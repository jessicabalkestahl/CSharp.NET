using System.Globalization;

namespace Exercise2;

internal class Exercise2
{
    public static void Main()
    {
        List<string?> names = new List<string?>();
        List<double?> grades = new List<double?>();
        
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter student {i + 1} name: ");
            names.Add(Convert.ToString(Console.ReadLine()));
            
            Console.Write($"Enter student {i + 1} grade: ");
            grades.Add(Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture));
        }
        
        Console.WriteLine();

        for (int i = 0; i < names.Count; i++)
        {
            string name = $"Name: {names[i]}".PadRight(15);
            Console.WriteLine($"[ Student {i + 1} ] {name} | Grade: {grades[i]}");
        }
        
        
    }
}