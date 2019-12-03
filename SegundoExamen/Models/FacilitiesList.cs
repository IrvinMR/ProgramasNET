using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SegundoExamen.Models{

    public class  FacilitiesList{
        public int FacilityID {get ; set;}
        public string FacilityDesc {get; set;}
        

        public ICollections<RoomsFacilities> RoomsFacilities {get; set;}
    }
}