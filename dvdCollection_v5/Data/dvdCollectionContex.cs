//el contexto es un archivo especial para las llaves primarias de las bases de datos
using Microsoft.EntityFrameworkCore;
using dvdCollection.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace dvdCollection.Data 
{
    public class dvdCollectionContext : IdentityDbContext<User>
    {
        public dvdCollectionContext(DbContextOptions<dvdCollectionContext> options) : base(options) 
        {
        }

        public DbSet<Actors> Actors {get; set;}
        public DbSet<FilmCertificates> FilmCertificates {get; set;}
        public DbSet<FilmGeneres> FilmGeneres {get; set;}
        public DbSet<FilmsActorRoles> FilmsActorRoles {get; set;}
        public DbSet<FilmTitles> FilmTitles {get; set;}
        public DbSet<FilmTitlesProducers> FilmTitlesProducers {get; set;}
        public DbSet<Producers> Producers {get; set;}
        public DbSet<RoleTypes> RoleTypes {get; set;}
        public DbSet<User> User {get; set;}

        //sobrecargar metodo para llaves primarias compartidas
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FilmTitlesProducers>().HasKey(c => new {c.ProducerID, c.FilmTitleID});
            modelBuilder.Entity<FilmsActorRoles>().HasKey(c => new {c.FilmTitleID, c.ActorID, c.RoleTypeID});
        }

    }
}
