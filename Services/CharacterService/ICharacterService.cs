using System.Collections.Generic;
using System.Threading.Tasks;
using csharp_rpg.Dtos.Character;
using csharp_rpg.Models;

namespace csharp_rpg.Services.CharacterService
{
   public interface ICharacterService
   {
      // define methods an the type of data it returns?
      Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
      Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
      Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
   }
}