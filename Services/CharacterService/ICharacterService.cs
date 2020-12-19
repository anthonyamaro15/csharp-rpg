using System.Collections.Generic;
using csharp_rpg.Models;

namespace csharp_rpg.Services.CharacterService
{
   public interface ICharacterService
   {
      // define methods an the type of data it returns?
      List<Character> GetAllCharacters();
      Character GetCharacterById(int id);
      List<Character> AddCharacter(Character newCharacter);
   }
}