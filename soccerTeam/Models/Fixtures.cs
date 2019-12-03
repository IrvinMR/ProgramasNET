using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace soccerTeam.Models {

    public class Fixtures {
        [Key]
        [Display(Name="ID")]
        public int FixtureID {get; set;}
        public string FixtureDate {get; set;}
        public string FixtureTime {get; set;}
        public int HomeTeamID {get; set;}
        public int AwayTeamID {get; set;}
        public int CompetitionID {get; set;}

        public Competitions Competitions {get; set;}

        public ICollection<PlayerFixtures> PlayerFixtures {get; set;} 

    }
}