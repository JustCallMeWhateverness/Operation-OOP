using OperationOOP.Core.Interfaces;

public class Equipment : IEntity //Composition, implements IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Classification { get; set; }
    
    public Equipment(int id, string name, string classification)
    {
        Id = id;
        Name = name;
        Classification = classification; //Armor, Weapon, Accessory
    }
}