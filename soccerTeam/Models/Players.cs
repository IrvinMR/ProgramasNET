using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace soccerTeam.Models {

    public class Players {
        [Key]
        [Display(Name="ID")]
        public int PlayerID {get; set;}
        public int TeamID {get; set;}
        [Display(Name="Name",Prompt="Nombre del jugador")]
        [Required(ErrorMessage="Nombre del jugador obligatorio")] //para que el campo sea obligatorio
        [StringLength(80)]
        public string PlayerName {get; set;}
        public int PlayerSquadNumber {get; set;}
        public int PositionID {get; set;}
        
        public Positions Position {get; set;}
        public Teams Team {get; set;}

        public ICollection<PlayerFixtures> PlayerFixtures {get; set;}
        
    }
}