using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SegundoExamen.Models{

    public class  RoomTypes{
        public int RoomTypeID {get ; set;}
        public string RoomType {get; set;}

        private ICollections<Rooms> room;

        public ICollections<Rooms> GetRoom()
        {
            return room;
        }

        public void SetRoom(ICollections<Rooms> value)
        {
            room = value;
        }
    }
}