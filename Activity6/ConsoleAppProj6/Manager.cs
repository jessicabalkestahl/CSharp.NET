using System.Text.Json;

namespace ConsoleAppProj6;

public class Manager : Worker
{
    public sealed override int Id { get; set; }
    public sealed override string? Name { get; set; }
    public sealed override double Salary { get; set; }
    public sealed override Department? Department { get; set; }
    public int NumOfWorkers { get; set; }
    public int ManagingHours { get; set; }
    public double Bonus { get; set; }

    public Manager(int id, string name, double salary, Department department, int numOfWorkers, int managingHours, double bonus)
    {
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
        this.Department = department;
        this.NumOfWorkers = numOfWorkers;
        this.ManagingHours = managingHours;
        this.Bonus = bonus;
    }
    
    public override string ToString()
    {
        return $"ID           : {this.Id}\n" +
               $"Name         : {this.Name}\n" +
               $"Salary       : {this.Salary}\n" +
               $"Department   : {this.Department}" +
               $"NumOfWorkers : {this.NumOfWorkers}\n" +
               $"ManagingHours: {this.ManagingHours}\n" +
               $"Bonus        : {this.Bonus}";
    }

    public int GetNumberOfWorkers()
    {
        Console.WriteLine($"The manager is managing {this.NumOfWorkers} worker(s).");
        return this.NumOfWorkers;
    }
    
    public int GetManagingHours()
    {
        Console.WriteLine($"The manager has been in this role for {this.ManagingHours} hours.");
        return this.ManagingHours;
    }
    
    public double GetBonus()
    {
        Console.WriteLine($"The manager has received a bonus of {this.Bonus} euros.");
        return this.Bonus;
    }
    
    public override double CalculateSalary()
    {
        return this.Salary + (this.Salary * this.Bonus);
    }
    
    public override string WorkerInfo()
    {
        return this.ToString();
    }
    
    public interface IJsonGenerator
    {
        string Generate(Manager data);
    }
    
    public class Json : IJsonGenerator
    {
        public string Generate(Manager data)
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(data, options);
        }
        
    }
}