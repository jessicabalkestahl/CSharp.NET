namespace ThrowException
{
    internal class Program 
    {
        internal static void Main()
        {
            Employee employee = new("Maria", 28);
            employee.ShowDetails();

            try
            {
                employee.ChangeAge(-4);
                employee.ShowDetails();
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine($"The age inserted: {e.GetAge()} is not valid.");
            }
        }
    }

    internal class Employee
    {
        private string? Name { get; }
        private int Age { get; set; }

        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int ChangeAge(int newAge)
        {
            if (newAge < 0)
            {
                throw new InvalidAgeException(newAge);
            }

            this.Age = newAge;
            return newAge;
        }

        public string ShowDetails()
        {
            string details = $"Employee: {this.Name} is {this.Age} years old.";
            Console.WriteLine(details);
            return details;
        }
    }

    [Serializable]
    internal class InvalidAgeException : ApplicationException
    {
        public int Age { get; set; }
        private string ErrorMessage { get; set; }
        

        public InvalidAgeException(int age)
            : base(String.Format("Invalid Age: {0}", age))
        {
            this.Age = age;
            this.ErrorMessage = $"Invalid age: {this.Age}";
        }

        public int GetAge()
        {
            return this.Age;
        }
        
        
    }
}