using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace soccerTeam.Models {

    public class Teams {
        [Key]  //Anotaciones se declaran con parentecis cuadrado y esta es un allave principal
        [Display(Name="ID")]
        public int TeamID { get; set;}
        [Display(Name="Name",Prompt="Nombre del equipo")]
        [Required(ErrorMessage="El nombre del equipo es obligatorio")] //para que el campo sea obligatorio
        [StringLength(40)]
        public string TeamName { get; set;}

        public ICollection<Players> Players { get; set;}

    }
}