namespace Exercise3
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Enter the first name and surname: ");
            string? name1 = Console.ReadLine();
            Console.Write("Enter the second name and surname: ");
            string? name2 = Console.ReadLine();
            Console.Write("Enter the third name and surname: ");
            string? name3 = Console.ReadLine();
            

            try
            {
                string[]? names1 = name1?.Split(' ');
                string[]? names2 = name2?.Split(' ');
                string[]? names3 = name3?.Split(' ');
                
                Console.WriteLine("Nome       Apelido");
                Console.WriteLine("==================");
                Console.WriteLine("{0}, {1}", names1?[0].PadRight(10), names1?[1]);
                Console.WriteLine("{0}, {1}", names2?[0].PadRight(10), names2?[1]);
                Console.WriteLine("{0}, {1}", names3?[0].PadRight(10), names3?[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}