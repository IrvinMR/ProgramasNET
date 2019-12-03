using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SegundoExamen.Models{

    public class  RoomsFacilities{
        public int RoomID {get ; set;}
        public int FacilityID {get ; set;}
        public string FacilityDetails {get; set;}
        
        public FacilitiesList FacilitiesList {get; set;}

        private Rooms rooms;

        public Rooms GetRooms()
        {
            return rooms;
        }

        public void SetRooms(Rooms value)
        {
            rooms = value;
        }
    }
}