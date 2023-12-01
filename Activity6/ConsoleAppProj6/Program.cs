
namespace ConsoleAppProj6
{
    internal static class InheritanceTest
    {
        public static void Main()
        {
            Department department = new Department(1, "Software Development");
            Secretary secretary = new(1, "Jess", 36000, department, 40, true);
            Manager manager = new(2, "Mi", 50000, department, 1, 35, 1000);

            secretary.ItSpeaksEnglish();
            secretary.GetWorkingHours();

            manager.GetNumberOfWorkers();
            manager.GetManagingHours();
            manager.GetBonus();
            
            Console.WriteLine($"The salary of the secretary is {secretary.CalculateSalary()} euros annually");
            Console.WriteLine($"The department of the secretary is {secretary.Department?.Designation}.");
            Console.WriteLine($"The salary of the manager is {manager.CalculateSalary()} euros annually.");
            Console.WriteLine($"The department of the manager is {manager.Department?.Designation}.");

            Manager.Json serializer = new();
            Console.WriteLine(serializer.Generate(manager));
        }
    }
}