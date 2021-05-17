using System.Threading.Tasks;
using DotNetCore_RPG.Dtos.Fight;
using DotNetCore_RPG.Models;

namespace DotNetCore_RPG.Services.FightService
{
    public interface IFightService
    {
         Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}