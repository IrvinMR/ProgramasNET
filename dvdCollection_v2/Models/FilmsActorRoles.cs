using System.Collections.Generic;
using system.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class FilmsActorRoles {
        public int FilmTitleID {get; set;}
        public int ActorID {get; set;}
        public int RoleTypeID {get; set;}
        [Display(Name="Name",Prompt="Nombre del personaje")]
        [Required(ErrorMessage="Nombre del personaje obligatorio")] //para que el campo sea obligatorio
        [StringLength(80)]
        public string CharacterName {get; set;}
        [Display(Name="Description",Prompt="Descripcion del personaje")]
        [Required(ErrorMessage="Descripcion de personaje obligatorio")] //para que el campo sea obligatorio
        [StringLength(80)]
        public string CharacterDescription {get; set;}

        public Actors Actor {get; set;}
        public RoleTypes RoleType {get; set;}
        public FilmTitles FilmTitle {get; set;}
        
    }
}