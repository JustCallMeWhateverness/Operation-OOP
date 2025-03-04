using OperationOOP.Core.Interfaces;

public class Equipment : IEntity
{
    public int id { get; set;}
    public string Name { get; set; }
    public string Classification { get; set; }
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Equipment(string name, string classification)
    {
        Name = name;
        Classification = classification;
    }
}