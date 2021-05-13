using System.Collections.Generic;
using System.Linq;
using DotNetCore_RPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id = 1, Name = "Sam"}
        };

        [Route("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}