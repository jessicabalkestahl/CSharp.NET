
namespace Exercise5
{
    internal static class Program
    {
        private static void Main()
        {
            var numbers = new List<double>();
            
            while (true)
            {
                Console.Write("Enter a number: ");
                double number = Convert.ToDouble(Console.ReadLine());
                
                if (number != 0)
                {
                    numbers.Add(number);
                    continue;
                };
                
                Console.WriteLine($"[Mean] {CalculateMean(numbers)}");
                Console.WriteLine($"[Sum]  {CalculateSum(numbers)}");
                Console.WriteLine($"[Max]  {CalculateHighestNumber(numbers)}");
                Console.WriteLine($"[Min]  {CalculateLowestNumber(numbers)}");
                return;
            }
                
        }
        
        private static double CalculateMean(List<double> numbers)
        {
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Count;
        }
        
        private static double CalculateSum(List<double> numbers)
        {
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        
        private static double CalculateHighestNumber(List<double> numbers)
        {
            double highest = numbers[0];
            foreach (int num in numbers)
            {
                if (num <= highest) continue;

                highest = num;
            }
            return highest;
        }
        
        private static double CalculateLowestNumber(List<double> numbers)
        {
            double lowest = numbers[0];
            foreach (int num in numbers)
            {
                if (num >= lowest) continue;

                lowest = num;
            }
            return lowest;
        }
    }
}