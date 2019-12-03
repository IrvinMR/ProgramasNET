namespace SegundoExamen.Models
{

    public class  Guests{
        public int GuestID {get ; set;}
        public string GuestTitle {get; set;}
        public string GuestForenames {get; set;}
        public string GuestSurnames {get; set;}
        public string GuestDOB {get; set;}
        public string GuestAddressStreet {get; set;}
        public string GuestAddressTown {get; set;}
        public string GuestAddressCountry {get; set;}
        public string GuestAddressPostalCode {get; set;}
        public string GuestContactPhone {get; set;}
        
        public ICollections<BookingsRooms> BookingsRooms {get; set;}
    }
}