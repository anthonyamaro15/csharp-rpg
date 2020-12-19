using System.Collections.Generic;
using System.Linq;
using csharp_rpg.Models;
using csharp_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace csharp_rpg.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class CharacterController : ControllerBase
   {
      // bring default data from Character Model
      // private static Character knight = new Character();


      // this will return an array of 2 Characters, the first one with the
      // default values and the second one with a different name
      // public static List<Character> characters = new List<Character> {
      //    new Character(),
      //    new Character { Id = 1, Name = "Sam"}
      // };

      // an easy way to understand this
      // import User from './models/users'
      // User.findById(id);
      // so _characterService is similar to 'User' you can access properties with '.' 
      private readonly ICharacterService _characterService;
      public CharacterController(ICharacterService characterService)
      {
         _characterService = characterService;
      }

      // HttpGet("getAll") is the URL define
      // in Node this will be the same as what you define in the route
      // route.get("/getAll")
      [HttpGet("getAll")]
      // if name starts with "Get" you don't need to specify the request type
      public IActionResult Get()
      {
         return Ok(_characterService.GetAllCharacters());
      }

      // this would be the same thing as "params" from Node.
      [HttpGet("{id}")]
      public IActionResult GetSingle(int id)
      {
         return Ok(_characterService.GetCharacterById(id));
      }

      // POST method
      [HttpPost]
      public IActionResult AddCharacter(Character newChar)
      {

         return Ok(_characterService.AddCharacter(newChar));
      }
   }
}