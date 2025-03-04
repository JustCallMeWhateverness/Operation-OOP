using OperationOOP.Core.Models;

public class Archer : Character
{
    public Archer(int id, string name, int level)
        : base(id, name, level, 120 + (level * 10), 20 + (level * 6), 10 + (level * 3))
    {

    }
}