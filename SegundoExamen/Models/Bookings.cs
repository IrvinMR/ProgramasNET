namespace SegundoExamen.Models
{

    public class  Bookings{
        public int BookingID {get ; set;}
        public int CustomerID {get ; set;}
        public string DateBookingMade {get; set;}
        public string TimeBookingMade {get; set;}
        public string BookedStartDate {get; set;}
        public string BookedEndDate {get; set;}
        public string TotalPaymentDueDate {get; set;}
        public string TotalPaymentDueAmount {get; set;}
        public string TotalPaymentMadeOn {get; set;}
        public string BookingComments {get; set;}

        public Customers Customers{get; set;}
        public ICollections<BookingsRooms> BookingsRooms {get; set;}
    }
}