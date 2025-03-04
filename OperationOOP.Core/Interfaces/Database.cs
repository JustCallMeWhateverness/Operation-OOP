using OperationOOP.Core.Models;

namespace OperationOOP.Core.Data
{
    public interface IDatabase
    {
        List<Character> Characters { get; set; }
        List<Equipment> Equipments { get; set; }
    }

    public class Database : IDatabase
    {
        public List<Character> Characters { get; set; } = new List<Character>();
        public List<Equipment> Equipments { get; set; } = new List<Equipment>();
    }
}
