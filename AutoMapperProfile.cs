using System.Linq;
using AutoMapper;
using DotNetCore_RPG.Dtos.Character;
using DotNetCore_RPG.Dtos.Skill;
using DotNetCore_RPG.Dtos.Weapon;
using DotNetCore_RPG.Models;

namespace DotNetCore_RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>()
                .ForMember(dto => dto.Skills, c => c.MapFrom(c=> c.CharacterSkills.Select(cs => cs.Skill)));
            CreateMap<AddCharacterDto,Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}