using System.Collections.Generic;
using DotNetCore_RPG.Models;

namespace DotNetCore_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter);
    }
}