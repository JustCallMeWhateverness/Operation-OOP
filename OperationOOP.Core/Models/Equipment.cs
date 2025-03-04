using System.Diagnostics.Contracts;

public class Equipment
{
    public string Name { get; set; }
    public string Type { get; set; }
    public Equipment(string name, string type)
    {
        Name = name;
        Type = type;
    }
}