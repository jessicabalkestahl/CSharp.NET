using System.Text.Json.Nodes;

namespace ConsoleAppProj6;

public class Secretary : Worker
{
    public sealed override int Id { get; set; }
    public sealed override string? Name { get; set; }
    public sealed override double Salary { get; set; }
    public sealed override Department? Department { get; set; }
    public int WorkingHours { get; set; }
    public bool SpeaksEnglish { get; set; }

    public Secretary(int id, string name, double salary, Department department, int workingHours, bool speaksEnglish)
    {
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
        this.Department = department;
        this.WorkingHours = workingHours;
        this.SpeaksEnglish = speaksEnglish;
    }
    
    public override string ToString()
    {
        return $"ID           : {this.Id}\n" +
               $"Name         : {this.Name}\n" +
               $"Salary       : {this.Salary}\n" +
               $"Department   : {this.Department}" +
               $"WorkingHours : {this.WorkingHours}\n" +
               $"SpeaksEnglish: {this.SpeaksEnglish}";
    }

    public int GetWorkingHours()
    {
        Console.WriteLine($"The secretary works {this.WorkingHours} hours a week.");
        return this.WorkingHours;
    }

    public bool ItSpeaksEnglish()
    {
        if (this.SpeaksEnglish)
        {
            Console.WriteLine("The secretary speaks English.");
        }
        else
        {
            Console.WriteLine("The secretary does not speak English.");
        }
        return this.SpeaksEnglish;
    }

    public override double CalculateSalary()
    {
        return this.Salary;
    }

    public override string WorkerInfo()
    {
        return this.ToString();
    }
}