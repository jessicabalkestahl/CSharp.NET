using System.Globalization;

namespace Exercise3;

internal class Exercise3
{
    public static void Main()
    {
        Article[] articles = CreateArticles();
        PrintArticles(articles);
        PrintExpensiveArticles(articles);

    }

    private static Article[] CreateArticles()
    {
        Article[] articles = new Article[5];
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter article's name: ");
            string? name = Convert.ToString(Console.ReadLine());
            
            Console.Write($"Enter article's price: ");
            double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Enter article's amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            articles[i] = new Article(name, price, amount);
        }

        return articles;
    }

    private static void PrintArticles(Article[] articles)
    {
        Console.WriteLine("\nPrinting all articles\n");
        for (int i = 0; i < articles.Length; i++)
        {
            string name = $"Name: {articles[i].Name}".PadRight(15);
            string price = $"Price: {articles[i].Price}".PadRight(15);
            string amount = $"Amount: {articles[i].Amount}";
            
            Console.WriteLine($"[ Article {i + 1} ] {name} | {price} | {amount}");
        }
    }
    
    private static void PrintExpensiveArticles(Article[] articles)
    {
        const int limit = 20;
        Console.WriteLine($"\nPrinting expensive articles above {limit}\n");
        for (int i = 0; i < articles.Length; i++)
        {
            if (!(articles[i].Price >= limit)) continue;
            
            string name = $"Name: {articles[i].Name}".PadRight(15);
            string price = $"Price: {articles[i].Price}".PadRight(15);
            string amount = $"Amount: {articles[i].Amount}";
                
            Console.WriteLine($"[ Article {i + 1} ] {name} | {price} | {amount}");
        }
    }

    private struct Article
    {
        public readonly string? Name; 
        public readonly double Price;
        public readonly int Amount;

        public Article(string? name, double price, int amount)
        {
            this.Name = name;
            this.Price = price;
            this.Amount = amount;
        }
    }
}