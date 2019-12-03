namespace SegundoExamen.Models
{

    public class  Rooms{
        public int RoomID {get ; set;}
        public string RoomTypeID {get; set;}
        public string RoomBanditID {get; set;}
        public string RoomPriceID {get; set;}
        public string Floor {get; set;}
        public string AdditionalNotes {get; set;}
        
        public ICollections<RoomsFacilities> RoomsFacilities {get; set;}
        public ICollections<BookingsRooms> BookingsRoom {get; set;}

        public RoomTypes RoomType {get; set;}
        public RoomBands RoomBand {get; set;}
        public RoomPrices RoomPrice {get; set;}

    }
}