using Microsoft.EntityFrameworkCore;
using soccerTeam.Models;

namespace soccerTeam.Data{
    public class soccerTeamContext : DbContext{
        public soccerTeamContext(DbContextOptions<soccerTeamContext> options) : base(options){
        }

        public DbSet<Teams> Teams {get; set;}
        public DbSet<Players> Players {get; set;}
        public DbSet<Fixtures> Fixtures {get; set;}
        public DbSet<PlayerFixtures> PlayerFixtures {get; set;}
        public DbSet<Competitions> Competitions {get; set;}
        public DbSet<Positions> Positions {get; set;}

        //sobrecargar metodo para llaves primarias compartidas
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<PlayerFixtures>().HasKey(c => new {c.FixtureID, c.PlayerID});
        }
    }
}