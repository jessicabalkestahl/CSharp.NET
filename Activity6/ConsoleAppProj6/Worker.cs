using System.Text.Json.Nodes;

namespace ConsoleAppProj6;

public abstract class Worker
{
    public abstract int Id { get; set; }
    public abstract string? Name { get; set; }
    public abstract double Salary { get; set; }
    public abstract Department? Department { get; set; }

    public Worker () {}
    public abstract double CalculateSalary();
    public abstract string WorkerInfo();
    
    public override string ToString()
    {
        return $"ID        : {this.Id}\n" +
               $"Name      : {this.Name}\n" +
               $"Salary    : {this.Salary}\n" +
               $"Department: {this.Department}";
    }
}