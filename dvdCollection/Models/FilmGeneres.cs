using System.Collections.Generic;
namespace dvdCollection.Models{

    public class  FilmGeneres{
        public int GenereID {get ; set;}
        public string GenereDesc {get; set;}

        public ICollections<FilmTitles> FilmTitles {get; set;}
    }
}