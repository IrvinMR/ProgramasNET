using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SegundoExamen.Models{

    public class  RoomPrices{
        public int RoomPriceID {get ; set;}
        public string RoomPrice {get; set;}

        private ICollections<RoomPrices> roomPrices;

        public ICollections<RoomPrices> GetRoomPrices()
        {
            return roomPrices;
        }

        public void SetRoomPrices(ICollections<RoomPrices> value)
        {
            roomPrices = value;
        }
    }
}