using System;
using System.Threading.Tasks;
using DotNetCore_RPG.Data;
using DotNetCore_RPG.Dtos.Fight;
using DotNetCore_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_RPG.Services.FightService
{
    public class FightService : IFightService
    {
        private readonly RpgDbContext _context;
        public FightService(RpgDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request)
        {
            ServiceResponse<AttackResultDto> response = new ServiceResponse<AttackResultDto>();
            try
            {
                Character attacker = await _context.characters
                    .Include(c => c.Weapon)
                    .FirstOrDefaultAsync(c => c.Id == request.AttackerId);
                Character opponent = await _context.characters
                    .FirstOrDefaultAsync(c => c.Id == request.OpponentId);
                
                int damage = attacker.Weapon.Damage + (new Random().Next(attacker.Strength));
                damage -= new Random().Next(opponent.Defense);

                if(damage > 0)
                    opponent.HitPoints -= damage;
                if(opponent.HitPoints <= 0)
                {
                    response.Message = $"{opponent.Name} has been defeated";
                }
                _context.characters.Update(opponent);
                await _context.SaveChangesAsync();

                response.Data = new AttackResultDto
                {
                    Attacker = attacker.Name,
                    AttackerHP = attacker.HitPoints,
                    Opponent = opponent.Name,
                    OpponentHP = opponent.HitPoints,
                    Damage = damage
                };
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}