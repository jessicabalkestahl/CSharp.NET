namespace Activity1;

internal class Exercise1
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        Console.Write("Enter your first grade: ");
        double grade1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your second grade: ");
        double grade2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your third grade: ");
        double grade3 = Convert.ToDouble(Console.ReadLine());

        double mean = Math.Round((grade1 + grade2 + grade3) / 3, 2);
        Console.WriteLine("[{0}] Final grade: {1}", name, mean);
    }
}