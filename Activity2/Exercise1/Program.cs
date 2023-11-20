
namespace Activity2;

internal class Exercise1
{
    public static void Main()
    {
        double[] numbers = new double[5];
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("");
        double sum = 0; 

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                sum += numbers[i];
            }
            else
            {
                Console.WriteLine($"[ Odd index {i} ] {numbers[i]}");
            }
        }
        
        Console.WriteLine($"[ Sum of even numbers ] {sum}");
        
        

        
    }
}