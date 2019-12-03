using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace soccerTeam.Models {

    public class Competitions {
        [Key]
        [Display(Name="ID")]
        public int CompetitionID {get; set;}
        [Display(Name="Competencia",Prompt="Nombre de la competencia")]
        [Required(ErrorMessage="Nombre de competencia obligatorio")]
        [StringLength(80)]
        public string CompetitionName {get; set;}
        
        public ICollection<Competitions> Competition {get; set;}
    }
}