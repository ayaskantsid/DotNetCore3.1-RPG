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
    }
}