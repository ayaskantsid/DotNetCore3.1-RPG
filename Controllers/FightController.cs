using System.Threading.Tasks;
using DotNetCore_RPG.Dtos.Fight;
using DotNetCore_RPG.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;
        public FightController(IFightService fightService)
        {
            _fightService = fightService;

        }

        [HttpPost("Weapon")]
        public async Task<IActionResult> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }
    }
}