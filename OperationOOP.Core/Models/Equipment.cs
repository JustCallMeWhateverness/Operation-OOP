using OperationOOP.Core.Interfaces;

public class Equipment : IEntity
{
    public string Name { get; set; }
    public string Classification { get; set; }
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Equipment(string name, string classification)
    {
        Name = name;
        Classification = classification;
    }
}