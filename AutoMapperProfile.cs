using AutoMapper;
using csharp_rpg.Dtos.Character;
using csharp_rpg.Models;

namespace csharp_rpg
{
   public class AutoMapperProfile : Profile
   {
      public AutoMapperProfile()
      {
         CreateMap<Character, GetCharacterDto>();
         CreateMap<AddCharacterDto, Character>();
      }
   }
}