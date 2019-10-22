using System.Collections.Generic;
using system.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class Actors {
        [Key]  //Anotaciones se declaran con parentecis cuadrado y esta es un allave principal
        [Display(Name="ID")]
        public int ActorID { get; set;}
        [Display(Name="Name",Prompt="Nombre completo del actor")]
        [Required(ErrorMessage="El nombre del actor es obligatorio")] //para que el campo sea obligatorio
        [StringLength(80)]
        public string ActorFullName { get; set;}
        [Required(Name="Notas",Prompt="Notas adicionales del actor")] //para que el campo sea obligatorio
        [StringLength(300)]
        public string ActorNotes { get; set;}

        public ICollection<FilmsActorRoles> FilmActorRoles { get; set;}

    }
}