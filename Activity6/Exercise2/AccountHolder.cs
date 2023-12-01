namespace Exercise2;

public class AccountHolder
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public AccountHolder(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
}