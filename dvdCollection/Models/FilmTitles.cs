using System;
using System.Collections.Generic;
namespace dvdCollection.Models{

    public class  FilmTitles{
        public int FilmTitleID {get ; set;}
        public string FilmTitle {get; set;}
        public string FilmStory {get; set;}
        public DateTime FilmReleaseDate {get; set; }
        public int FilmDuration {get; set;}
        public int FilmGenereID {get; set;}
        public int FilmCertificateID {get; set;}
        public string FilmAditionalInfo {get; set;}

        public FilmGeneres Genere {get; set;}     //Representa lo que llega de una relacion muchos, lo que entra muchos a uno
        public Certificates Certificate {get; set;}

        public ICollections<FilmTitlesProducers> FilmTitlesProducers {get; set;} //conexiones entre las tablas, lo que sale 1 a muchos 
        public ICollections<FilmActorRoles > FilmActorRoles {get; set;}

    }
}
