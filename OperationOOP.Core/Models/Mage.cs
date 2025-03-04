using OperationOOP.Core.Models;

public class Mage : Character
{
    public Mage(int id, string name, int level)
        : base(id, name, level, 100 + (level * 8), 25 + (level * 6), 10 + (level * 2))
    {
    }
}
