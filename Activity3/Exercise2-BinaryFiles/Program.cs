
namespace Exercise2;

internal static class Exercise2
{
    private struct Credentials
    {
        public readonly string Username;
        public readonly string Password;

        public Credentials(string user, string pass)
        {
            Username = user;
            Password = pass;
        }
    }

    private const string FileName = "credentials.cat";
    
    public static void Main()
    {
        const string username = "jessica.balkestahl";
        const string password = "123456";

        Credentials credentials = new(username, password);
        SaveCredentials(credentials);
        PrintCredentials(FileName);
    }

    private static void SaveCredentials(Credentials credentials)
    {
        try
        {
            using StreamWriter sw = new(FileName);
            
            sw.WriteLine($"Username: {credentials.Username}");
            sw.WriteLine($"Password: {credentials.Password}");
            
        }
        catch (Exception e)
        {
            Console.WriteLine("Couldn't write in the file.");
            Console.WriteLine(e.Message);
        }
    }


    private static void PrintCredentials(string fileName)
    {
        try
        {
            using StreamReader sr = new(fileName);

            while (sr.ReadLine() is { } line)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Couldn't access the file.");
            Console.WriteLine(e.Message);
        }
    }
}