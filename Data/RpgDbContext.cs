using DotNetCore_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_RPG.Data
{
    public class RpgDbContext : DbContext
    {
        public RpgDbContext(DbContextOptions<RpgDbContext> options) : base(options)
        {
            
        }

        public DbSet<Character> characters {get;set;}
        public DbSet<User> users {get; set;}
        public DbSet<Weapon> weapons {get; set;}
        public DbSet<Skill> skills {get; set;}
        public DbSet<CharacterSkill> characterSkills {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterSkill>().HasKey(cs => new {cs.CharacterId, cs.SkillId});
        }
    }
}