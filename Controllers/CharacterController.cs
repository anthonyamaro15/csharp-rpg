using System.Collections.Generic;
using System.Linq;
using csharp_rpg.Models;
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
      public static List<Character> characters = new List<Character> {
         new Character(),
         new Character { Id = 1, Name = "Sam"}
      };

      // HttpGet("getAll") is the URL define
      // in Node this will be the same as what you define in the route
      // route.get("/getAll")
      [HttpGet("getAll")]
      // if name starts with "Get" you don't need to specify the request type
      public IActionResult Get()
      {
         return Ok(characters);
      }

      // this would be the same thing as "params" from Node.
      [HttpGet("{id}")]
      public IActionResult GetSingle(int id)
      {
         return Ok(characters.FirstOrDefault(c => c.Id == id));
      }

      // POST method
      [HttpPost]
      public IActionResult AddCharacter(Character newChar)
      {
         characters.Add(newChar);
         return Ok(characters);
      }
   }
}