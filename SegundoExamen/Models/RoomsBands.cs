using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SegundoExamen.Models{

    public class  RoomBands{
        public int RoomBandID {get ; set;}
        public string BandDesc {get; set;}
        

        public ICollections<RoomBands> RoomBand {get; set;}
    }
}