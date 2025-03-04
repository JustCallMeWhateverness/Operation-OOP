using OperationOOP.Core.Models;

public class Warrior : Character
{
    public Warrior(int id, string name, int level)
        : base(id, name, level, 150 + (level * 10), 20 + (level * 5), 15 + (level * 3))
    {
    }
}