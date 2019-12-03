using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace soccerTeam.Models {

    public class Positions {
        [Key]
        public int PositionID { get; set;}
        public string PositionDesc { get; set;}

        public ICollection<Players> Players { get; set;}

    }
}