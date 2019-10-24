using System.Linq;
using Microsoft.EntityFrameworkCore;
using dvdCollection.Models;

namespace dvdCollection.Data {
    public static class DbInitializer{
        public static void Initializate(dvdCollectionContext context){
            context.Database.EnsureCreated();

            if(context.FilmGeneres.Any()){
                return;
            }

            // Arreglo del tipo FilmGeneres
            var FilmGeneres = new FilmGeneres[]{
                new FilmGeneres{GenreDesc="Action"},
                new FilmGeneres{GenreDesc="Adventure"},
                new FilmGeneres{GenreDesc="Animation"},
                new FilmGeneres{GenreDesc="Biography"},
                new FilmGeneres{GenreDesc="Comedy"},
                new FilmGeneres{GenreDesc="Crime"},
                new FilmGeneres{GenreDesc="Drama"},
                new FilmGeneres{GenreDesc="Family"},
                new FilmGeneres{GenreDesc="Fantasy"},
                new FilmGeneres{GenreDesc="History"}
            };

            //pasar arreglo a la tabla de filmgeneres
            foreach (FilmGeneres g in FilmGeneres)
            {
                context.FilmGeneres.Add(g);
            }
            //grabar los datos en la BD fisica
            context.SaveChanges();
        }
        
    }
}