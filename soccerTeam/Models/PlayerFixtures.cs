using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace soccerTeam.Models {

     public class PlayerFixtures {
        public int FixtureID { get; set;}
        public int PlayerID { get; set;}
        public int GoalsScored { get; set;}
        
        public Fixtures Fixture { get; set;}
        public Players Player { get; set;}
         

    }
}