using OperationOOP.Core.Models;

namespace OperationOOP.Core.Services
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();
        List<Character> GetCharactersByLevel(int minLevel);
        void AddCharacter(Character character);  
        List<Equipment> GetSortedEquipment();
    }
    public class CharacterService : ICharacterService
    {
        private List<Character> _characters = new List<Character>();

        public List<Character> GetAllCharacters()
        {
            return _characters;
        }

        public List<Character> GetCharactersByLevel(int minLevel)
        {
            return _characters.Where(c => c.Level >= minLevel).ToList();
        }

        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }

        public List<Equipment> GetSortedEquipment()
        {
            return _characters.SelectMany(c => c.Equipment).OrderByDescending(e => e.Classification).ToList();
        }
    }
}