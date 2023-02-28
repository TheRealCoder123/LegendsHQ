using LegendsHQ.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LegendsHQ.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Ability> abilitys { get; set; }
        public DbSet<AbilityInteraction> abilityInteractions { get; set; }
        public DbSet<AbilityTips> abilityTips { get; set; }
        public DbSet<Legend> legends { get; set; }
        public DbSet<LegendClass> legendClasses { get; set; }
        public DbSet<LegendFinishers> legendFinishers { get; set; }
        public DbSet<LegendImages> legendImages { get; set; }
        public DbSet<LegendVideo> legendVideos { get; set; }
        public DbSet<Skin> legendSkins { get; set; }




    }
}
