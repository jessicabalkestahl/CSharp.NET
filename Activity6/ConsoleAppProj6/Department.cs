namespace ConsoleAppProj6;

public class Department
{
    public int DepartmentId { get; set; }
    public string? Designation { get; set; }

    public Department(int departmentId, string designation)
    {
        DepartmentId = departmentId;
        Designation = designation;
    }
    
    public override string ToString()
    {
        return $"DepartmentId: {DepartmentId}\n" +
               $"Designation : {Designation}";
    }
}