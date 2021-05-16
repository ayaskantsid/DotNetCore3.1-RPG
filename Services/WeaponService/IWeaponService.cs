using System.Threading.Tasks;
using DotNetCore_RPG.Dtos.Character;
using DotNetCore_RPG.Dtos.Weapon;
using DotNetCore_RPG.Models;

namespace DotNetCore_RPG.Services.WeaponService
{
    public interface IWeaponService
    {
         Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}