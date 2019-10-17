using System.Collections.Generic;
namespace dvdCollection.Models{

    public class  RolesType{
        public int RolesTyoeID {get ; set;}
        public string RoleDesc {get; set;}
        public string RoleDesc {get; set;}

        public ICollections<FilmsActorRoles> FilmActorRoles {get; set;}
    }
}