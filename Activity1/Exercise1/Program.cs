namespace Activity1;

internal class Exercise1
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        Console.Write("Enter your first grade: ");
        int grade1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your second grade: ");
        int grade2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your third grade: ");
        int grade3 = Convert.ToInt32(Console.ReadLine());

        float result = (grade1 + grade2 + grade3) / 3f;
        double mean = Math.Round(result, 2);
        Console.WriteLine("[{0}] Final grade: {1}", name, mean);
    }
}