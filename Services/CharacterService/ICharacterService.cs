using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCore_RPG.Dtos.Character;
using DotNetCore_RPG.Models;

namespace DotNetCore_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
    }
}