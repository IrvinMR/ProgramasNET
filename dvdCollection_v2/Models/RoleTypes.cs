using System.Collections.Generic;
using system.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class RoleTypes {
        [Key]
        public int RoleTypeID { get; set;}
        public string RoleDesc { get; set;}

        public ICollection<FilmsActorRoles> FilmActorRoles { get; set;}

    }
}