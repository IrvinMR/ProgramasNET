using System.Collections.Generic;
namespace dvdCollection.Models{

    public class  Certificates{
        public int CertificateID {get ; set;}
        public string Certificate {get; set;}

        public ICollections<FilmTitles> FilmTitle {get; set;}
    }
}