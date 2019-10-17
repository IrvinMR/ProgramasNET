using System.Collections.Generic;
namespace dvdCollection.Models{

    public class  Actors{
        public int ActorID {get ; set;}
        public string ActorFullName {get; set;}
        public string ActorNotes {get; set;}

        public ICollections<FilmsActorRoles> FilmActorRole {get; set;}
    }
}
