using System.Collections.Generic;

namespace DotNetCore_RPG.Models
{
    public class CharacterSkill
    {
        public int CharacterId { get; set; }
        public int SkillId { get; set; }
        public Character Character { get; set; }
        public Skill Skill { get; set; }
        public List<CharacterSkill> CharacterSkills { get; set; }
    }
}