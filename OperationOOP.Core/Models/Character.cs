using OperationOOP.Core.Interfaces;

namespace OperationOOP.Core.Models;
//Bas class that inherits from IEntity
public abstract class Character : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public List<Equipment> Equipment { get; set; } 

    public Character(int id, string name, int level, int health, int attack, int defense)
    {
        Id = id;
        Name = name;
        Level = level;
        Health = health;
        Attack = attack;
        Defense = defense;
        Equipment = new List<Equipment>();
    }
}